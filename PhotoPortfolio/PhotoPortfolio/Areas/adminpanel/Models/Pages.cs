using PhotoPortfolio.Models;

namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Pages:Base
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public DateTime Publishdate { get; set; }
        public string? PageContent { get; set; }
        public string? ButtonTitle { get; set; }
        public string? ButtonURL { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutImgUrl { get; set; }
        public string? AddressTitle { get; set; }
        public string? Address { get; set; }
        public string? EmailTitle { get; set; }
        public string? Email { get; set; }
        public string? PhoneTitle { get; set; }
        public string? Phone { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceDescription { get; set; }
        public double? ServicePrice { get; set; }
        public string? Icon { get; set; }
        public string LayoutName { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
