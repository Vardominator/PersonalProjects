using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Text;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPdotNETCoreTest.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/

        // The Index method uses a view template to generate an HTML response to the browser
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld/Welcome

        public string Welcome(string name, int numTimes = 1)
        {
            StringBuilder testSB = new StringBuilder();

            for (int i = 0; i < numTimes; i++)
            {
                testSB.Append(name + "\n");
            }

            return testSB.ToString();
        }

        public string WhatsUp()
        {
            return "Sup fuckers";
        }

    }
}
