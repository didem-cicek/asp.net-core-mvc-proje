using Microsoft.AspNetCore.Http;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class AboutViewModel: PageTitle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile PageImgUrl { get; set; }
    }
}
