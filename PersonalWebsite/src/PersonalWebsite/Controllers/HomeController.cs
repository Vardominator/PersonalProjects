using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.ViewModel;
using PersonalWebsite.Services;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;


        // Whenever this controller is called it will try to use an implementation of the
        //  IMailService interface. When it creates the controller it tries supply the mailservice
        //  but it does not yet know of it. This is taken care of in startup
        public HomeController(IMailService mailService)
        {
            _mailService = mailService;
        }


        public IActionResult Index()
        {
            return View();
        }


        // Reach me
        public IActionResult Contact()
        {

            return View();
        }

        // If someone posts to the action that is contact, this is the method that should be instantiated
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            _mailService.SendMail("varderes@gmail.com", model.Email, "From Personal website", model.Message);
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
