﻿using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("~/hakkimizda")]
        public IActionResult Aboutus()
        {
            return View();
        }

        [Route("~/iletişim")]
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}