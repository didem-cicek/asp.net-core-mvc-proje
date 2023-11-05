namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class HomePage : Base
    {
        public string ButtonTitle { get; set; }
        public string ButtonURL { get; set; }

        public int PagesId { get; set; }
        public Pages Pages { get; set; }
    }
}
