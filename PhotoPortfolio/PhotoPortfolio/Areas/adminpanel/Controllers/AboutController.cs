using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //[HttpPost]
        //public async Task<IActionResult> Create(AboutViewModel model)
        //{
        //    var pagesData = _context.Pages.Add(new() { PageTitle = model.Title, PageContent = model.Description, Publishdate = model.Publishdate });
        //    var pagesId = await _context.Pages.FirstOrDefaultAsync(x => x.PageTitle == model.Title);
        //    if (pagesId == null)
        //    {
        //        _context.SaveChangesAsync();
        //    }
           
        //    if(model.PageImgUrl != null)
        //    {
        //        var extension = Path.GetExtension(model.PageImgUrl.FileName);
        //        var newImageName = Guid.NewGuid() + extension;
        //        var location = Path.Combine(_webHostEnvironment.WebRootPath, @"C:\Users\didem\Documents\GitHub\asp.net-core-mvc-proje\PhotoPortfolio\PhotoPortfolio\wwwroot\\adminpanel\images\", newImageName);
        //        var stream = new FileStream(location, FileMode.Create);
        //        model.PageImgUrl.CopyTo(stream);
        //        var aboutData = _context.Abouts.Add(new() { PageImgUrl = newImageName, PagesId = pagesId.Id });
        //        _context.SaveChangesAsync();
        //    }
            
        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Edit(int id)
        //{
        //    AboutCreateViewModel model = new AboutCreateViewModel();

        //    var result = await _context.Abouts.FirstOrDefaultAsync(x => x.Id == id);

        //    if (result != null)
        //    {
        //        model.Title = result.Pages.PageTitle;
        //        model.Description = result.Pages.PageContent;
        //        model.PageImgUrl = result.PageImgUrl;
        //        model.Publishdate = DateTime.Now;

        //        return View(model);

        //    }

        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(AboutEditViewModel model, About article, int id)
        //{
        //        var result = await _context.Abouts.FirstOrDefaultAsync(x => x.Id == id);
        //        result.Pages.PageTitle = model.Title;
        //        result.Pages.PageContent = model.Description;
        //        result.Pages.Publishdate = DateTime.Now;
        //        if (model.PageImgUrl != null)
        //        {
        //            var extension = Path.GetExtension(model.PageImgUrl.FileName);
        //            var newImageName = Guid.NewGuid() + extension;
        //            var location = Path.Combine(Directory.GetCurrentDirectory(), "~/adminpanel/images/", newImageName);
        //            var stream = new FileStream(location, FileMode.Create);
        //            model.PageImgUrl.CopyTo(stream);
        //            result.PageImgUrl = newImageName;
        //        }
        //        await _context.AddAsync(article);
        //        await _context.SaveChangesAsync();
        //        return View(result);
        //}
    }
}
