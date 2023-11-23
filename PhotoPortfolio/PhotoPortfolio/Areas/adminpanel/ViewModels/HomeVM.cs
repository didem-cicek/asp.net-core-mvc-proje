using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonTitle { get; set; }
        public string ButtonURL { get; set; }

        public DateTime PublishDate { get; set; }
        public int UserId { get; set; }
        public AppUser appUser { get; set; }

    }
}
