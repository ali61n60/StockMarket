
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RepositoryStd;
using ModelStd.Carts;

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

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


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
            app.UseSession();
                    
            app.UseMvc(endpoints =>
            {
                

                endpoints.MapRoute("symbolPageRoute",
                    "{symbolGroup}/Page{symbolPage:int}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapRoute("pageRoute",
                    "Page{symbolPage:int}",
                new { Controller = "Home", action = "Index", symbolPage = 1 });

                endpoints.MapRoute("symbolRoute",
                    "{symbolGroup}",
                new { Controller = "Home", action = "Index", symbolPage = 1 });

                endpoints.MapRoute("pagination",
                "symbolGroup/Page{symbolPage}",
                new { Controller = "Home", action = "Index", symbolPage = 1 });

                endpoints.MapRoute("MvcDefault",
                   "{Controller}/{action}",
                   new {Controller="Home", action="Index" });

                endpoints.MapRoute("default",
                    "",
                    new { Controller = "Home", action = "Index", symbolPage = 1 });
            });
           // app.UseMvcWithDefaultRoute();
        }
    }
}
