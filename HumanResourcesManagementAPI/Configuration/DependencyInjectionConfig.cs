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
            services.AddScoped<IRepository<Candidato>, Repository<Candidato>>();
            services.AddScoped<IRepositoryCandidato, RepositoryCandidato>();
            services.AddScoped<IRepository<Colloquio>, Repository<Colloquio>>();
            services.AddScoped<IRepositoryColloquio, RepositoryColloquio>();
            services.AddScoped<IRepository<Contratto>, Repository<Contratto>>();
            services.AddScoped<IRepositoryContratto, RepositoryContratto>();
            services.AddScoped<IRepository<Dipendente>, Repository<Dipendente>>();
            services.AddScoped<IRepositoryDipendente, RepositoryDipendente>();
            services.AddScoped<IRepository<EsperienzeLavorative>, Repository<EsperienzeLavorative>>();
            services.AddScoped<IRepositoryEsperienzeLavorative, RepositoryEsperienzeLavorative>();
            services.AddScoped<IRepository<HardSkill>, Repository<HardSkill>>();
            services.AddScoped<IRepositoryHardSkill, RepositoryHardSkill>();
            services.AddScoped<IRepository<LivelloContrattuale>, Repository<LivelloContrattuale>>();
            services.AddScoped<IRepositoryLivelloContrattuale, RepositoryLivelloContrattuale>();
            services.AddScoped<IRepository<Mansione>, Repository<Mansione>>();
            services.AddScoped<IRepositoryMansione, RepositoryMansione>();
            services.AddScoped<IRepository<Sede>, Repository<Sede>>();
            services.AddScoped<IRepositorySede, RepositorySede>();
            services.AddScoped<IRepository<SoftSkill>, Repository<SoftSkill>>();
            services.AddScoped<IRepositorySoftSkill, RepositorySoftSkill>();
            services.AddScoped<IRepository<TitoloDiStudio>, Repository<TitoloDiStudio>>();
            services.AddScoped<IRepositoryTitoloDiStudio, RepositoryTitoloDiStudio>();

        }


    }
}
