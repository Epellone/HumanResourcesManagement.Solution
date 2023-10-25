using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryMansione : Repository<Mansione>, IRepositoryMansione
    {
        public RepositoryMansione(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
