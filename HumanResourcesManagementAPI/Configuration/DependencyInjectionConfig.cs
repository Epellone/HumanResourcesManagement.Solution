using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;
using HumanResourcesManagementAPI.Repository;

namespace HumanResourcesManagementAPI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IRepository<Benefits>, Repository<Benefits>>();
            services.AddScoped<IRepositoryBenefits, RepositoryBenefits>();
            services.AddScoped<IRepository<Sede>, Repository<Sede>>();
            services.AddScoped<IRepositorySede, RepositorySede>();
            services.AddScoped<IRepository<Candidato>, Repository<Candidato>>();
            services.AddScoped<IRepositoryCandidato, RepositoryCandidato>();
        }


    }
}
