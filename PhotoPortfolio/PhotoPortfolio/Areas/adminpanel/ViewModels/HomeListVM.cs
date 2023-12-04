using Microsoft.CodeAnalysis;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeListVM : PageTitle
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string LayoutName { get; set; }
    }
}
