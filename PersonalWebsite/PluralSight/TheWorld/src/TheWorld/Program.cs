using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TheWorld
{
    public class Program
    {

        // This is the starting point of all of the code
        public static void Main(string[] args)
        {
            // A Web host that listens to requests. It specifies that the things that are important. 
            var host = new WebHostBuilder()
                .UseKestrel()               // Web server under ASP.NET Core
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()        // Add support for IIS
                .UseStartup<Startup>()      // Use class called Startup to set up web server 
                .Build();                   // Builds web host

            host.Run();
        }
    }
}
