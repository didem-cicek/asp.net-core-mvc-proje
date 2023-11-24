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
                model.PageT = result.PageTitle;
                model.PageDescription = result.PageDescription;
                model.PageButtonTitle = result.ButtonTitle;
                model.PageButtonURL = result.ButtonURL;
                return View(model);
            }
            
            return View(model);
        }

        public async Task<IActionResult> About()
        {
            var model = new AboutPageViewModel();
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "About");
            if (result != null)
            {
                model.PageT = result.PageTitle;
                model.PageDescription = result.PageDescription;
                model.PageButtonTitle = result.ButtonTitle;
                model.PageButtonURL = result.ButtonURL;
                model.Title = result.AboutTitle;
                model.Description = result.PageContent;
                model.PageImgUrl = result.AboutImgUrl;
                return View(model);
            }
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}