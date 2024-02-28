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
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICarModelService, CarModelServices>();
            services.AddScoped<IFinancialService, FinancialServices>();
            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();
            return services;
        }

    }
}
