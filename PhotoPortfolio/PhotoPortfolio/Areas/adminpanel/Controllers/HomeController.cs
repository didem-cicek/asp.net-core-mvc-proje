using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
        private readonly UserManager<AppUser> _userManager;

        public HomeController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _context.Pages.ToListAsync();
            if (result != null)
            {
                var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                var model = result.Select(x => new HomeListVM()
                {
                    PageTitle = x.PageTitle,
                    PageContent = x.PageDescription,
                    Publishdate = x.Publishdate,
                    Id = x.Id,
                    UserName = currentUser.UserName, 
                }).OrderBy(x => x.PageTitle).ToList();
                TempData["UserName"] = currentUser.UserName;

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
                var model = result.Select(x => new HomeListVM()
                {
                    PageTitle = x.PageTitle,
                    PageContent = x.PageDescription,
                    Publishdate = x.Publishdate,
                    Id = x.Id,
                }).OrderBy(x => x.PageTitle).ToList();

                return View(model);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(HomeCreateVM home)
        {
            Pages pages = new Pages();
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "HomePage");
            if (result == null)
            {
                result.PageTitle = home.Title;
                result.PageDescription = home.Description;
                result.ButtonTitle = home.ButtonTitle;
                result.ButtonURL = home.ButtonURL;
                result.Publishdate = DateTime.Now;
                result.LayoutName = "HomePage";
                await _context.AddAsync(pages);
                await _context.SaveChangesAsync();

            }else
            {
                return RedirectToAction("Edit", "Home");
            }
            return View(home);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            HomeEditVM home = new HomeEditVM();

            var result = await _context.Pages.FirstOrDefaultAsync(x =>x.LayoutName=="HomePage");

            if (result != null)
            {
                home.Title = result.PageTitle;
                home.Description = result.PageDescription;
                home.ButtonTitle = result.ButtonTitle;
                home.ButtonURL = result.ButtonURL;
                home.PublishDate = result.Publishdate;

                return View(home);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HomeEditVM home, int id)
        {
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "HomePage");

            if (result != null)
            {
                result.PageTitle = home.Title;
                result.PageDescription = home.Description;
                result.ButtonTitle = home.ButtonTitle;
                result.ButtonURL = home.ButtonURL;
                result.Publishdate = DateTime.Now;
                _context.Update(result);
                await _context.SaveChangesAsync();

            }
            return View();
        }
    }
}
