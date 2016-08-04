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


        // Reach me
        public IActionResult ReachMe()
        {

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
