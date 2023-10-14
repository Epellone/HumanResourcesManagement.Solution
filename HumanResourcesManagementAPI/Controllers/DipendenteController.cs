using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class DipendenteController : Controller<Dipendente>
    {
        public DipendenteController(IRepository<Dipendente> repository) : base(repository)
        {
        }
    }
}
