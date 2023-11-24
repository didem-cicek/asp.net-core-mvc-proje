using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeVM :PageTitle
    {
        public int UserId { get; set; }
        public AppUser appUser { get; set; }

    }
}
