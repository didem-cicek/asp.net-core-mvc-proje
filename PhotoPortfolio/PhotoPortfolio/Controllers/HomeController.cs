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
            var model = new HomeVM();
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "HomePage");
            if (result !=null)
            {
                model.Title = result.PageTitle;
                model.Description = result.PageDescription;
                model.ButtonTitle = result.ButtonTitle;
                model.ButtonURL = result.ButtonURL;
                return View(model);
            }
            
            return View(model);
        }

        public async Task<IActionResult> About(AboutPageViewModel model)
        {
            //var result2 = await _context.Pages.FirstOrDefaultAsync(x => x.PageTitle ==);
            //model.Title = result2.PageTitle;
            //model.Description = result2.PageContent;
            //model.PageImgUrl = result.PageImgUrl;
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}