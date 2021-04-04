using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RepositoryStd;

namespace StockMVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddDbContext<StockDbContext>(opts => {
                opts.UseSqlServer(
                Configuration["ConnectionStrings:DefaultConnection"]);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            //  app.UseNodeModules(env.ContentRootPath);
                     

         
            app.UseMvc(endpoints =>
            {
                endpoints.MapRoute("pagination",
                    "Symbols/Page{productPage}",
                    new { Controller = "Home", action = "Index" });
            });
            app.UseMvcWithDefaultRoute();
        }
    }
}
