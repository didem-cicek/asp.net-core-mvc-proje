﻿namespace PhotoPortfolio.Areas.adminpanel.ViewModels
{
    public class PhotoViewModel
    {
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public IFormFile PageImgUrl { get; set; }
    }
}
