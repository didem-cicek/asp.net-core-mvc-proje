namespace PhotoPortfolio.Models
{
    public class Photo:Base
    {
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Gallery> Gallery { get; set; }
    }
}
