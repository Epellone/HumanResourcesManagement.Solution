using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryContratto : Repository<Contratto>, IRepositoryContratto
    {
        public RepositoryContratto(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
