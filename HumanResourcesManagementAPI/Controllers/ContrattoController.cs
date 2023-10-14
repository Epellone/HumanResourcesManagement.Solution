using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class ContrattoController : Controller<Contratto>
    {
        public ContrattoController(IRepository<Contratto> repository) : base(repository)
        {
        }
    }
}
