﻿namespace PhotoPortfolio.Areas.adminpanel.Models
{
    public class GalleryCategory : Base
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Gallery> Gallery { get; set; } = new List<Gallery>();
    }
}
