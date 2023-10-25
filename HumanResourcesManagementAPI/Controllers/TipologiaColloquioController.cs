using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class TipologiaColloquioController : Controller<TipologiaColloquio>
    {
        public TipologiaColloquioController(IRepository<TipologiaColloquio> repository) : base(repository)
        {
        }
    }
}
