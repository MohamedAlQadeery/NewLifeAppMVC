using NewLife.Web.Services.Interfaces;

namespace NewLife.Web.Services
{
    public static class ServicesDependancyInjection
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IImageService, ImageService>();

            return services;
        }
    }
}
