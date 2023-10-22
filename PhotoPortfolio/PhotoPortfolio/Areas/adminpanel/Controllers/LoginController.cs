using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhotoPortfolio.Areas.adminpanel.Models;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class LoginController : Controller
    {
        
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser appuser = new AppUser()
                {
                    UserName = model.Name,
                    Email = model.Email,
                };
                var result = await userManager.CreateAsync(appuser, model.Password);
                if (result.Succeeded) { 
                    RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
