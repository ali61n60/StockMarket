using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "node_modules");
            var fileprovider = new PhysicalFileProvider(path);
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = fileprovider;
            app.UseStaticFiles(options);
            return app;
        }
    }
}
