﻿using Microsoft.AspNetCore.Mvc;

namespace mayur_education.Controllers
{
    public class AboutPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
