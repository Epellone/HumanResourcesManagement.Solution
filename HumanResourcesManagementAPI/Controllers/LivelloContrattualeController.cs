using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class LivelloContrattualeController : Controller<LivelloContrattuale>
    {
        public LivelloContrattualeController(IRepository<LivelloContrattuale> repository) : base(repository)
        {
        }
    }
}
