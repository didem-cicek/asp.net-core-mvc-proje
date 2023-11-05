namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class About : Base
    {
        public string PageImgUrl { get; set; }
        public int PagesId { get; set; }
        public Pages Pages { get; set; }
    }
}
