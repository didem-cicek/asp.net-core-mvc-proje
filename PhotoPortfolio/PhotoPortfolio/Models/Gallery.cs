namespace PhotoPortfolio.Models
{
    public class Gallery:Base
    {
        public string GalleryPageTitle { get; set; }
        public string GalleryPageContent { get; set; }  
        public int GalleryCategoryId { get; set; }
        public GalleryCategory Categories { get; set; }
        public string ProjectUrl { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Client {  get; set; }
        public string ClientNote { get; set; }
        public int PhotoId { get; set; }
        public Photo Photos { get; set; }
    }
}
