using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class TipologiaDocumentoController : Controller<TipologiaDocumento>
    {
        public TipologiaDocumentoController(IRepository<TipologiaDocumento> repository) : base(repository)
        {
        }
    }
}
