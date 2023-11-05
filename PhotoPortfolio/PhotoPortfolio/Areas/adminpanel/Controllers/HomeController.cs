using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoPortfolio.Areas.adminpanel.Models;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _context.Pages.ToListAsync();
            if (result != null)
            {
                var model = result.Select(x => new HomeListViewModel()
                {
                    PageTitle = x.PageTitle,
                    PageContent = x.PageContent,
                    Publishdate = x.Publishdate,
                    Id = x.Id,
                }).OrderBy(x => x.PageTitle).ToList();

                return View(model);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> HomeList()
        {
            var result = await _context.Pages.ToListAsync();
            if (result != null)
            {
                var model = result.Select(x => new HomeListViewModel()
                {
                    PageTitle = x.PageTitle,
                    PageContent = x.PageContent,
                    Publishdate = x.Publishdate,
                    Id = x.Id,
                }).OrderBy(x => x.PageTitle).ToList();

                return View(model);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> HomeEdit(int id)
        {
            HomeViewModel home = new HomeViewModel();

            var result = await _context.HomePages.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                home.Title = result.Pages.PageTitle;
                home.Description = result.Pages.PageContent;
                home.ButtonTitle = result.ButtonTitle;
                home.ButtonURL = result.ButtonURL;
                home.PublishDate = result.Pages.Publishdate;

                return View(home);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HomeEdit(HomeViewModel model, HomePage article, int id)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.HomePages.FindAsync(id);
                result.Pages.PageTitle = model.Title;
                result.Pages.PageContent = model.Description;
                result.Pages.Publishdate = DateTime.Now;
                result.ButtonTitle = model.Title;
                result.ButtonURL = model.ButtonURL;
                await _context.AddAsync(article);
                await _context.SaveChangesAsync();
                return View(result);
            }
            return View();
        }
    }
}
