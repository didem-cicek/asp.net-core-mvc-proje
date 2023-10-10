using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Views.Shared.Components.ArticleVC
{
    public class ArticleVC:ViewComponent
    {
        private readonly BlogDbContext context;

        public ArticleVC(BlogDbContext context)
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
