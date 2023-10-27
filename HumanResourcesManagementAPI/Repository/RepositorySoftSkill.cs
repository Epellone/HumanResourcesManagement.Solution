using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositorySoftSkill : Repository<SoftSkill>, IRepositorySoftSkill
    {
        public RepositorySoftSkill(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
