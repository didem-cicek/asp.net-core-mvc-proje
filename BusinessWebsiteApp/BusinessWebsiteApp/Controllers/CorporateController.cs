using Microsoft.AspNetCore.Mvc;

namespace BusinessWebsiteApp.Controllers
{
    public class CorporateController : Controller
    {
        [Route("~/hakkimizda")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/sertifikalar")]
        public IActionResult Certificates()
        {
            return View();
        }
        [Route("~/yonetim-kurulu")]
        public IActionResult BoardofDirectors()
        {
            return View();
        }
        [Route("~/foto-galeri")]
        public IActionResult FotoGallery()
        {
            return View();
        }
    }
}
