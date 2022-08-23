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
            services.AddScoped<IWalletService, WalletService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ITypeMoneyService, TypeMoneyService>();
            services.AddScoped<ICashService, CashService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserProfile());
                mc.AddProfile(new WalletProfile());
                mc.AddProfile(new TypeMoneyProfile());
                mc.AddProfile(new CardProfile());
                mc.AddProfile(new CashProfile());
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
