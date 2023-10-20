using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryTipologiaContratto : Repository<TipologiaContratto>, IRepositoryTipologiaContratto
    {
        public RepositoryTipologiaContratto(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
