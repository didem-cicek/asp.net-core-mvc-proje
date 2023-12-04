using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoPortfolio.Areas.adminpanel.Service;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class Category : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMessageService _messageService;
        public Category(AppDbContext context, IMessageService messageService)
        {
            _context = context;
            _messageService = messageService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _context.GalleryCategories.ToListAsync();
            if (result != null)
            {
                var model = result.Select(x => new CategoryListVM()
                {
                    CategoryName = x.CategoryName,
                    CategoryDescription = x.CategoryDescription.Length > 50 ? x.CategoryDescription.Substring(0, 50) + "..." : x.CategoryDescription,
                    Id = x.Id,

                }).OrderBy(x => x.CategoryName).ToList();
                return View(model);
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryVM model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.CategoryName))
                {
                    _messageService.AddError("Lütfen Kategori Adını Boş Bırakmayınız!");
                    ViewBag._messageService = (IMessageService)_messageService;
                    return View(); // Hata durumunda aynı view'e geri dön
                }
                var CategoryExits = _context.GalleryCategories.Any(c => c.CategoryName == model.CategoryName);
                // Kategori adının daha önce kullanılıp kullanılmadığını kontrol et
                if (CategoryExits)
                {
                    _messageService.AddError("Bu Kategori Adı Daha Önceden Eklenmiştir!");
                    ViewBag._messageService = (IMessageService)_messageService;
                    return View(); // Hata durumunda aynı view'e geri dön
                }
                var result = _context.GalleryCategories.Add(new() { CategoryName = model.CategoryName, CategoryDescription= model.CategoryDescription });
                if (result != null)
                {
                    IMessageService messageService = new MessageService();
                    await _context.SaveChangesAsync();
                }
            
                _messageService.AddSuccess("Kategori başarıyla eklendi");
                ViewBag._messageService = (IMessageService)_messageService;
            }
            catch (Exception ex)
            {
                _messageService.AddError("Kategori eklenemedi!", ex);
                ViewBag._messageService = (IMessageService)_messageService;
            }
            return View(model);

        }
    }
}
