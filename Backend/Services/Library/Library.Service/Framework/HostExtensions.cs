using Library.Service.Framework.Web;
using Scalar.AspNetCore;

namespace Library.Service.Framework
{
    public static class HostExtensions
    {
        public static IServiceCollection AddHostServices(this IServiceCollection services, IConfigurationManager configuration)
        {
            services.AddOpenApi();
            return services;
        }
        public static async Task<WebApplication> UseHostSetupAsync(this WebApplication app)
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options => { options.Servers = Array.Empty<ScalarServer>(); });
            app.MapAllEndpoints();
            return app;
        }
    }
}
