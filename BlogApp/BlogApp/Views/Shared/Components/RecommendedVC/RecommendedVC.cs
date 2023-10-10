using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Views.Shared.Components.RecommendedVC
{
    public class RecommendedVC:ViewComponent
    {
        private readonly BlogDbContext context;

        public RecommendedVC(BlogDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = context.Articles.ToList();

            return View(model);
        }
    }
}
