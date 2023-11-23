using PhotoPortfolio.Areas.adminpanel.Models;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class GalleryViewModel
    {
        public string GalleryPageTitle { get; set; }
        public string GalleryPageContent { get; set; }
        public DateTime PublishDate { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string ProjectUrl { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Client { get; set; }
        public string ClientNote { get; set; }
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public IFormFile PhotoURL { get; set; }
    }
}
