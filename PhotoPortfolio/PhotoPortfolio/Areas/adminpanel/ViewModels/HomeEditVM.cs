namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class HomeEditVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonTitle { get; set; }
        public string ButtonURL { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
