using Microsoft.AspNetCore.Http;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class AboutViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile PageImgUrl { get; set; }
        public DateTime Publishdate { get; set; }
    }
}
