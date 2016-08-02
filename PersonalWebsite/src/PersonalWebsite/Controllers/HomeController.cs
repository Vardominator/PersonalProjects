using System;
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


        // Who I am 
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        // Reach me
        public IActionResult ReachMe()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult WhoIAm()
        {

            return View();
        }
        
        public IActionResult WhatIDo()
        {
            return View();
        }

        public IActionResult WhatIWrite()
        {
            return View();
        }

        public IActionResult WhatIveDone()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
