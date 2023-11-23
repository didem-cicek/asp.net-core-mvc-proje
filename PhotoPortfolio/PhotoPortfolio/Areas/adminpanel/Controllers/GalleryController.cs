using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryCreate(GalleryCategoryViewModel model)
        {
            var pagesData = _context.GalleryCategories.Add(new() { CategoryName = model.CategoryName});
            if (pagesData != null)
            {
                _context.SaveChangesAsync();
            }
           
            return View(model);
        }

    }
}
