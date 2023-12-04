using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhotoPortfolio.Areas.adminpanel.Models;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class GalleryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GalleryController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            var vm = new GalleryCreateVM();
            vm.GalleryCategory = (from c in _context.GalleryCategories
                             select new SelectListItem
                             {
                                 Text = c.CategoryName,
                                 Value = c.Id.ToString(),
                                 Selected = true
                             }).ToList();
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(GalleryCreateVM model)
        {
            Gallery pages = new Gallery();
            var c = await _context.GalleryCategories.FirstOrDefaultAsync(x => x.Id == model.GalleryCategoryId);
            if (pages != null)
            {
                pages.GalleryPageTitle = model.GalleryPageTitle;
                pages.GalleryPageContent = model.GalleryPageContent;
                pages.GalleryCategoryId = c.Id;
                pages.ProjectName = model.ProjectName;
                pages.ProjectDescription = model.ProjectDescription;
                pages.ProjectUrl = model.ProjectUrl;
                pages.PublishDate = DateTime.Now;
                pages.Client = model.Client;
                pages.ClientNote = model.ClientNote;

                if (model.Photos != null)
                {
                    for(int i = 0; i < model.Photos.Count; i++) { 
                    var extension = Path.GetExtension(model.Photos[i].FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var webRootPath = _webHostEnvironment.WebRootPath;
                    var location = Path.Combine(webRootPath, "adminpanel/images", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.Photos[i].CopyTo(stream);
                    pages.Photo = new Photo { PhotoUrl = newImageName, PhotoName = newImageName };
                    await _context.AddAsync(pages);
                    await _context.SaveChangesAsync();
                    }

                }
                
                return View(model);
            }
            else
            {
                return RedirectToAction("Edit", "About");
            }

        }

    }
}
