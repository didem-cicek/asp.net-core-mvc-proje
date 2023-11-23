using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeCreateVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonTitle { get; set; }
        public string ButtonURL { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
