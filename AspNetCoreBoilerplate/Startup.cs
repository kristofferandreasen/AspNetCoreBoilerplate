using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBoilerplate
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // This is where the repository is added as a service
            // MockItemRepository is the concrete implementation
            // services.AddTransient<IItemRepository, MockItemRepository>();

            // The real database repository is added as a service
            // services.AddTransient<IItemRepository, ItemRepository>();
            
            // Add framework services.
            // The AddMvc adds the features from the regular MVC Framework
            services.AddMvc();

            // This section adds the database context using the default connection from the appsettings.json file
            // services.AddDbContext<AppDbContext>(options =>
               // options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            
            // Middleware for the development environment
            if (env.IsDevelopment())
            {
                // In development mode, you will see a detailed error description
                app.UseDeveloperExceptionPage();

                // Browserlink enables you to launch the project in the browser you want
                app.UseBrowserLink();

                // Seed the database with the inital data
                // DbInitializer.Seed(context);
            }
            else
            {
                // In production, the Home/Error route will be used
                app.UseExceptionHandler("/Home/Error");
            }

            // This allow us to serve static files - images
            app.UseStaticFiles();

            // MVC is middleware for the request - forward the request to an action
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
