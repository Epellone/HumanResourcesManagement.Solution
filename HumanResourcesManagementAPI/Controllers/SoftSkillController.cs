using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class SoftSkillController : Controller<SoftSkill>
    {
        public SoftSkillController(IRepository<SoftSkill> repository) : base(repository)
        {
        }
    }
}
