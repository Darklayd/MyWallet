using Api.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public static class ServiceExtensions
    {
        public static void AddControllers(this IServiceCollection services)
        {
            services.AddSingleton<TestModel>();
        }
    }
}
