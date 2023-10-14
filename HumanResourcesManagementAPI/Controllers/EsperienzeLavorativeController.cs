using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class EsperienzeLavorativeController : Controller<EsperienzeLavorative>
    {
        public EsperienzeLavorativeController(IRepository<EsperienzeLavorative> repository) : base(repository)
        {
        }
    }
}
