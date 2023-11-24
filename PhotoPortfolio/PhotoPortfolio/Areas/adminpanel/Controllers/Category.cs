using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class Category : Controller
    {
        private readonly AppDbContext _context;
        public Category(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryVM model)
        {
            var result = _context.GalleryCategories.Add(new() { CategoryName = model.CategoryName, CategoryDescription= model.CategoryDescription });
            if (result != null)
            {
                _context.SaveChangesAsync();
            }

            return View(model);

        }
    }
}
