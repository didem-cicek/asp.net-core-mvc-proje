using Microsoft.AspNetCore.Mvc;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    public class PhotoController1cs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
