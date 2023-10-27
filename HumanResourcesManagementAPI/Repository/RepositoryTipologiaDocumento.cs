using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryTipologiaDocumento : Repository<TipologiaDocumento>, IRepositoryTipologiaDocumento
    {
        public RepositoryTipologiaDocumento(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
