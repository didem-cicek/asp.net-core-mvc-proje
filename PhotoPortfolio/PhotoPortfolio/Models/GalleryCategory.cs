namespace PhotoPortfolio.Models
{
    public class GalleryCategory:Base
    {
        public string CategoryName { get; set; }
        public ICollection<Gallery> Gallery { get; set; }
    }
}
