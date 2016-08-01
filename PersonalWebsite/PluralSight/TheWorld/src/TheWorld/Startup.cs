using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TheWorld.Services;
using Microsoft.Extensions.Configuration;

namespace TheWorld
{
    public class Startup
    {

        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)      // Tell the builder where the config lives
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();             // Make the config file overridable      

            _config = builder.Build();

        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // This single instance will be supplied everywhere that it is used
            services.AddSingleton(_config);

            if (_env.IsEnvironment("Development") || _env.IsEnvironment("Testing"))
            {
                // Our own services
                services.AddScoped<IMailService, DebugMailService>();
            }
            else
            {
                // Implement a real Mail service
            }

            // In ASP.NET core we are required to use dependency injection
            // The job of this method is to set up the service container that the different parts of the application requires
            // Essentially registers all MVC services
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Method that is called to set up what to do when requests come in. Code that is being written and called everytime a request comes in.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseDefaultFiles();

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();


            // Enable middleware to start listening to routes that we want
            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" }
                    );
            }); 
            // MVC requires a number of services, interfaces, objects in order to do its job
            app.UseMvc();

        }
    }
}
