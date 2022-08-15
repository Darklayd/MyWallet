using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            // Приклад підключення сервісів
            // services.AddScoped<IAuthenticationService, AuthenticationService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                // Приклад підключення правил мапінгу
                // mc.AddProfile(new UserProfiles());
            });

            var mapper = configures.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddFluentValidation(this IServiceCollection services)
        {
            // приклад підкулючення валідації вхідних даних
            // services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<UserRegistrationValidation>());
        }
    }
}
