namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Pages:Base
    {
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public DateTime Publishdate { get; set; }

        public ICollection<About> Abouts { get; set; } = new List<About>();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public ICollection<Service> Services { get; set; } = new List<Service>();

        public ICollection<HomePage> Home { get; set; } = new List<HomePage>();

    }
}
