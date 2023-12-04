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
                    PageT = x.PageTitle,
                    PageDescription = x.PageDescription.Length > 50 ? x.PageDescription.Substring(0, 50) + "..." : x.PageDescription,
                    PublishDate = x.Publishdate,
                    Id = x.Id,
                    UserName = currentUser.UserName, 
                    Email = currentUser.Email,
                    LayoutName = x.LayoutName,
                }).OrderBy(x => x.PageT).ToList();
                TempData["UserName"] = currentUser.UserName;
                TempData["Email"] = currentUser.Email;

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
                    PageT = x.PageTitle,
                    PageDescription = x.PageDescription,
                    PublishDate = x.Publishdate,
                    Id = x.Id,
                    LayoutName = x.LayoutName,
                }).OrderBy(x => x.PageT).ToList();

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
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "Home");
            if (result == null)
            {
                pages.PageTitle = home.PageT;
                pages.PageDescription = home.PageDescription;
                pages.ButtonTitle = home.PageButtonTitle;
                pages.ButtonURL = home.PageButtonURL;
                pages.Publishdate = DateTime.Now;
                pages.LayoutName = "Home";
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

            var result = await _context.Pages.FirstOrDefaultAsync(x =>x.LayoutName=="Home");

            if (result != null)
            {
                home.PageT = result.PageTitle;
                home.PageDescription = result.PageDescription;
                home.PageButtonTitle = result.ButtonTitle;
                home.PageButtonURL = result.ButtonURL;
                home.PublishDate = result.Publishdate;

                return View(home);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HomeEditVM home, int id)
        {
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "Home");

            if (result != null)
            {
                result.PageTitle = home.PageT;
                result.PageDescription = home.PageDescription;
                result.ButtonTitle = home.PageButtonTitle;
                result.ButtonURL = home.PageButtonURL;
                result.Publishdate = DateTime.Now;
                _context.Update(result);
                await _context.SaveChangesAsync();

            }
            return View();
        }
    }
}
