using Microsoft.AspNetCore.Mvc;

namespace PhotoPortfolio.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
