namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class Comment : Base
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string User { get; set; }
        public string Jop { get; set; }
        public string ProfileUrl { get; set; }
        public string Rating { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
