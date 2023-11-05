using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;
using System.Diagnostics;

namespace PhotoPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _context.HomePages.ToListAsync();
            var model = result.Select(x => new HomeViewModel()
            {
                Title = x.Pages.PageTitle,
                Description = x.Pages.PageContent,
                ButtonTitle = x.ButtonTitle,
                ButtonURL = x.ButtonURL,
            }).ToList();
            return View(model);
        }

        public async Task<IActionResult> About(AboutPageViewModel model)
        {
            var result = await _context.Abouts.FirstOrDefaultAsync();
            var result2 = await _context.Pages.FirstOrDefaultAsync(x => x.Id == result.PagesId);
            model.Title = result2.PageTitle;
            model.Description = result2.PageContent;
            model.PageImgUrl = result.PageImgUrl;
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}