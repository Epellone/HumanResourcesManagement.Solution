using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryDipendente : Repository<Dipendente>, IRepositoryDipendente
    {
        public RepositoryDipendente(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
