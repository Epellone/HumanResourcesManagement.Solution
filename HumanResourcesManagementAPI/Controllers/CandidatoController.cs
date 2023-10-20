using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class CandidatoController : Controller<Candidato>
    {
        public CandidatoController(IRepository<Candidato> repository) : base(repository)
        {
        }
    }
}
