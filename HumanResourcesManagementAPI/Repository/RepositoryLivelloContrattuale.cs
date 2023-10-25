using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryLivelloContrattuale : Repository<LivelloContrattuale>, IRepositoryLivelloContrattuale
    {
        public RepositoryLivelloContrattuale(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
