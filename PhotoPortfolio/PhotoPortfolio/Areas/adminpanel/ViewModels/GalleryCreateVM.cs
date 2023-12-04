using Microsoft.AspNetCore.Mvc.Rendering;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class GalleryCreateVM
    {
        public string GalleryPageTitle { get; set; }
        public string GalleryPageContent { get; set; }
        public DateTime PublishDate { get; set; }    
        public string ProjectUrl { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Client { get; set; }
        public string ClientNote { get; set; }

        public int GalleryCategoryId { get; set; }
        public List<SelectListItem> GalleryCategory { get; set; }
        public List<IFormFile> Photos { get; set; } = new List<IFormFile>();
    }
}
