namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class AboutEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile PageImgUrl { get; set; }
        public DateTime Publishdate { get; set; }
    }
}
