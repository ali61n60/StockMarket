﻿using Microsoft.AspNetCore.Builder;
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
using Microsoft.AspNetCore.ResponseCompression;
using System.Linq;
using StockMVC.Hubs;

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

            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddServerSideBlazor();

            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if(env.IsStaging())
            {
                int i = 10;
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            // Approach 1: Writing a terminal middleware.
            app.Use(next => async context =>
            {
                if (context.Request.Path == "/")
                {
                    await context.Response.WriteAsync("Hello terminal middleware!");
                    return;
                }

                await next(context);
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Approach 2: Using routing.
                endpoints.MapGet("/Movie", async context =>
                {
                    await context.Response.WriteAsync("Hello routing!");
                });
            });

            //app.UseEndpoints(endpoints =>
            //{

            //    endpoints.MapBlazorHub();
            //    endpoints.MapHub<ChatHub>("/chathub");
            //    endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

            //    endpoints.MapControllerRoute(
            //     name: "default",
            //     pattern: "{Controller=home}/{action=index}/{symbolGroup=1}/{symbolPage=1}");
            //});



        }

       
    }
}
