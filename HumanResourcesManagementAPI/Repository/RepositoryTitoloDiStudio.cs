using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Repository
{
    public class RepositoryTitoloDiStudio : Repository<TitoloDiStudio>, IRepositoryTitoloDiStudio
    {
        public RepositoryTitoloDiStudio(ApplicationDBContext dbcontext) : base(dbcontext)
        {
        }
    }
}
