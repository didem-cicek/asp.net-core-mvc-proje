using Microsoft.AspNetCore.Mvc;

namespace PhotoPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
