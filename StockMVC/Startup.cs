using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using RepositoryStd;
using ModelStd.Carts;
using ModelStd.IRepository;
using RepositoryStd.Database.Repository;
using Microsoft.AspNetCore.ResponseCompression;
using System.Linq;
using StockMVC.Hubs;
using ServiceStd.IService;
using ServiceStd;
using StockMVC.PushNotification;

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
            services.AddDbContext<StockDbContext>(opts =>
            {
                opts.UseSqlServer(
                Configuration["ConnectionStrings:DefaultConnection"]);
            });
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ISymbolService, SymbolService>();
            services.AddServerSideBlazor();
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
            services.AddSignalR();
            services.AddHostedService<PushNotificationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            app.UseWebSockets();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapHub<ChatHub>("/chathub");
                
               // endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");


                //endpoints.MapControllerRoute(
                //    name: "R1",
                //    pattern: "{controller=RouteTest}/{action=Index}/{x=2}.{z=4}");

                endpoints.MapControllerRoute(
                    name: "popular",
                    pattern: "{controller=Chart}/{action=Index}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{symbolGroup=1}/{symbolPage=1}");

                endpoints.MapFallbackToController("Index", "Todo");
            });
        }
    }
}
