﻿using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        [Route("~/blog")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/blog/{id}")]
        public IActionResult Detail(string id)
        {
            return View(id);
        }
    }
}
