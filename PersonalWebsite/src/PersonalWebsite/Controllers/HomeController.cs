﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // Reach me
        public IActionResult Contact()
        {

            return View();
        }
        
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
