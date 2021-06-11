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
            app.UseWebSockets();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("symbolPageRoute",
                //    "{symbolGroup}/Page{symbolPage:int}",
                //    new { Controller = "Home", action = "Index" });

                //endpoints.MapControllerRoute("pageRoute",
                //    "Page{symbolPage:int}",
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

                //endpoints.MapControllerRoute("default",
                //    "",
                //    new { Controller = "Home", action = "Index", symbolPage = 1 });
                
                //endpoints.MapDefaultControllerRoute();
                //endpoints.MapRazorPages();
                //endpoints.MapBlazorHub();
                //endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

                //endpoints.MapControllers();
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/ws")
                {
                    if (!context.WebSockets.IsWebSocketRequest)
                    {
                        using (WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync())
                        {
                            await  Echo(context, webSocket);
                        }
                    }
                    else
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    }
                }
                else
                {
                    await next();
                }

            });

        }

        private async Task Echo(HttpContext context, WebSocket webSocket)
        {
            var buffer = new byte[1024 * 4];
            WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            while (!result.CloseStatus.HasValue)
            {
                await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, result.Count), result.MessageType, result.EndOfMessage, CancellationToken.None);

                result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            }
            await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
        }
    }
}
