namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class AboutEditViewModel : PageTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile PageImgUrl { get; set; }
    }
}
