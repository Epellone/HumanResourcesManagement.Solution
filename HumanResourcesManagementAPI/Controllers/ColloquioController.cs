using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class ColloquioController : Controller<Colloquio>
    {
        public ColloquioController(IRepository<Colloquio> repository) : base(repository)
        {
        }
    }
}
