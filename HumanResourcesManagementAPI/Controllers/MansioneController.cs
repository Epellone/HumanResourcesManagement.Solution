using HumanResourcesManagementAPI.Models.Classi;

namespace HumanResourcesManagementAPI.Controllers
{
    public class MansioneController : Controller<Mansione>
    {
        public MansioneController(Models.Interface.IRepository<Mansione> repository) : base(repository)
        {
        }
    }
}
