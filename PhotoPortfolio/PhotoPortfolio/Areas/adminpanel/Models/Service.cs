namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Service : Base
    {
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public double ServicePrice { get; set; }
        public string Icon { get; set; }
        public int PagesId { get; set; }
        public Pages Pages { get; set; }
    }
}
