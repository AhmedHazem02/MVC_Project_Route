﻿using Microsoft.AspNetCore.Mvc;

namespace WebP1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ConnectUs() { 
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
