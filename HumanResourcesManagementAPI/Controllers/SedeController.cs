using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class SedeController : Controller<Sede>
    {
        public SedeController(IRepository<Sede> repository) : base(repository)
        {
        }
    }
}
