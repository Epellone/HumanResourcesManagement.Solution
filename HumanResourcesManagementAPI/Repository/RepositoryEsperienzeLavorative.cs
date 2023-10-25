using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryEsperienzeLavorative : Repository<EsperienzeLavorative>, IRepositoryEsperienzeLavorative
    {
        public RepositoryEsperienzeLavorative(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
