using CarModelRegister.Application.Domain.Interface;
using CarModelRegister.Application.Infra.Data.Repository;
using CarModelRegister.Application.Services;

namespace CarModelApi.Extension
{
    public static class ServiceCollection
    {

        public static IServiceCollection AddFeaturesServices(this IServiceCollection services)
        {
            services.AddServices();
            services.AddRepository();
            services.AddControllers();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICarModelServices, CarModelServices>();
            services.AddScoped<IFinancialServices, FinancialServices>();
            services.AddScoped<FinancialServices>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IFinancialRepository, FinancialRepository>();
            return services;
        }

       
    }
}
