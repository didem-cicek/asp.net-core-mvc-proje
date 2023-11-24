namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Photo:Base
    {
        public string PhotoName { get; set; }
        public string PhotoUrl { get; set;}

        public ICollection<Gallery> Gallery { get; set; }
    }
}
