using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryTipologiaColloquio : Repository<TipologiaColloquio>, IRepositoryTipologiaColloquio
    {
        public RepositoryTipologiaColloquio(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
