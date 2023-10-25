using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryHardSkill : Repository<HardSkill>, IRepositoryHardSkill
    {
        public RepositoryHardSkill(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
