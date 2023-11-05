using Microsoft.CodeAnalysis;

namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeListViewModel
    {
        public int? Id { get; set; }
        public string? PageTitle { get; set; }
        public string? PageContent { get; set; }
        public DateTime? Publishdate { get; set; }

    }
}
