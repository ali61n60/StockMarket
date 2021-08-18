using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RepositoryStd;
using ModelStd.Carts;
using ModelStd.IRepository;
using RepositoryStd.Database.Repository;
using System.Net.WebSockets;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Threading;

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
            
            services.AddControllersWithViews();

            services.AddDbContext<StockDbContext>(opts => {
                opts.UseSqlServer(
                Configuration["ConnectionStrings:DefaultConnection"]);
            });

            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddServerSideBlazor();
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
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("symbolPageRoute",
                //    "{symbolGroup}/Page{symbolPage:int}",
                //    new { Controller = "Home", action = "Index" });

                //endpoints.MapControllerRoute("pageRoute",
                //"Page{symbolPage:int}",
                //new { Controller = "Home", action = "Index", symbolPage = 1 });

                //endpoints.MapControllerRoute("symbolRoute",
                //    "{symbolGroup}",
                //new { Controller = "Home", action = "Index", symbolPage = 1 });

                //endpoints.MapControllerRoute("pagination",
                //"symbolGroup/Page{symbolPage}",
                //new { Controller = "Home", action = "Index", symbolPage = 1 });

                //endpoints.MapControllerRoute("MvcDefault",
                //   "{Controller}/{action}",
                //   new { Controller = "Home", action = "Index" });



                // endpoints.MapDefaultControllerRoute();
                //endpoints.MapRazorPages();
                //endpoints.MapBlazorHub();
                //endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

                //endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/hello/{name:alpha}", async context =>
            {
                var name = context.Request.RouteValues["name"];
                await context.Response.WriteAsync($"Hello {name}!");
            });

             endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{Controller}/{action}/{symbolGroup=1}/{symbolPage=1}");
            });

           

        }

       
    }
}
