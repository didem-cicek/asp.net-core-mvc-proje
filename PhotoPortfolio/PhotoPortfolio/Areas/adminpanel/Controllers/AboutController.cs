using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using PhotoPortfolio.Areas.adminpanel.Models;
using PhotoPortfolio.Areas.adminpanel.ViewModels;
using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AboutViewModel model)
        {
            Pages pages = new Pages();
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "About");
            if (result == null)
            {
                pages.PageTitle = model.PageT;
                pages.PageDescription = model.PageDescription;
                pages.ButtonTitle = model.PageButtonTitle;
                pages.ButtonURL = model.PageButtonURL;
                pages.AboutTitle = model.Title;
                pages.PageContent = model.Description;
                pages.Publishdate = DateTime.Now;
                pages.LayoutName = "About";

                if (model.PageImgUrl != null)
                {
                    var extension = Path.GetExtension(model.PageImgUrl.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var webRootPath = _webHostEnvironment.WebRootPath;
                    var location = Path.Combine(webRootPath, "adminpanel/images", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.PageImgUrl.CopyTo(stream);
                    pages.AboutImgUrl = newImageName;

                }
                await _context.AddAsync(pages);
                await _context.SaveChangesAsync();
                return View(model);
            }
            else
            {
                return RedirectToAction("Edit", "About");
            }           
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            AboutCreateViewModel model = new AboutCreateViewModel();

            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName=="About");

            if (result != null)
            {
                model.PageT = result.PageTitle;
                model.PageDescription = result.PageDescription;
                model.PageButtonTitle = result.ButtonTitle;
                model.PageButtonURL = result.ButtonURL;
                model.Title = result.AboutTitle;
                model.Description = result.PageContent;

                return View(model);

            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AboutEditViewModel model, int id)
        {
            var result = await _context.Pages.FirstOrDefaultAsync(x => x.LayoutName == "About");
            if (result != null)
            {
                result.PageTitle = model.PageT;
                result.PageDescription = model.PageDescription;
                result.ButtonTitle = model.PageButtonTitle;
                result.ButtonURL = model.PageButtonURL;
                result.AboutTitle = model.Title;
                result.PageContent = model.Description;
                result.Publishdate = DateTime.Now;
                if (model.PageImgUrl != null)
                {
                    var extension = Path.GetExtension(model.PageImgUrl.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var webRootPath = _webHostEnvironment.WebRootPath;
                    var location = Path.Combine(webRootPath, "adminpanel/images", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    model.PageImgUrl.CopyTo(stream);
                    result.AboutImgUrl = newImageName;
                }
                 _context.Update(result);
                await _context.SaveChangesAsync();
            }
           
            return View();
        }
    }
}
