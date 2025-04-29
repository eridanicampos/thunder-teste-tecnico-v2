using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Thunders.TechTest.Domain.Interfaces.Commons;
using Thunders.TechTest.Infrastructure.Repositories.Commons;
using Thunders.TechTest.Domain.Interfaces.Repositories;
using Thunders.TechTest.Infrastructure.Repositories;
using Thunders.TechTest.Infrastructure.UnitOfWorks;

namespace Thunders.TechTest.Infrastructure.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationRoot configuration)
        {
            AddRepositoriesServices(services);
            AddValidators(services);
            return services;
        }


        public static void AddRepositoriesServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IGenericAsyncRepository<>), typeof(GenericAsyncRepository<>));
            services.AddScoped<IUtilizacaoRepository, UtilizacaoRepository>();
            services.AddScoped<IPracaRepository, PracaRepository>();

        }

        public static void AddStoreProcedures(IServiceCollection services)
        {

        }
        public static void AddValidators(IServiceCollection services)
        {
            //services.AddValidatorsFromAssemblyContaining<VendaValidator>(); 
        }
    }
}
