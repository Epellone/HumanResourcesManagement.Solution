using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class TitoloDiStudioController : Controller<TitoloDiStudio>
    {
        public TitoloDiStudioController(IRepository<TitoloDiStudio> repository) : base(repository)
        {
        }
    }
}
