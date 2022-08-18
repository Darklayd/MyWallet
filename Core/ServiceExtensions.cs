using AutoMapper;
using Core.AutoMapper.ApplicationProfiles;
using Core.Interfaces.CustomService;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserProfile());
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
