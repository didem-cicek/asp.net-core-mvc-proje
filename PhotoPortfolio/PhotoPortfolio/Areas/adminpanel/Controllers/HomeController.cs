using Microsoft.AspNetCore.Mvc;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
