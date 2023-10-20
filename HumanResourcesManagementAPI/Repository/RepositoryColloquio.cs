using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryColloquio : Repository<Colloquio>, IRepositoryColloquio
    {
        public RepositoryColloquio(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
