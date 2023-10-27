using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class TipologiaContrattoController : Controller<TipologiaContratto>
    {
        public TipologiaContrattoController(IRepository<TipologiaContratto> repository) : base(repository)
        {
        }
    }
}
