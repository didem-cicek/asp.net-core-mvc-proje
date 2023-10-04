using Microsoft.AspNetCore.Mvc;

namespace BusinessWebsiteApp.Controllers
{
    public class ServicesController : Controller
    {
        [Route("~/hizmetler")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/hizmetler/{id}")]
        public IActionResult Detail(string id)
        {
            return View(id);
        }
    }
}
