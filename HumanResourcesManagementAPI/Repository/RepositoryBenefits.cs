using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryBenefits : Repository<Benefits> , IRepositoryBenefits
    {
        public RepositoryBenefits(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
