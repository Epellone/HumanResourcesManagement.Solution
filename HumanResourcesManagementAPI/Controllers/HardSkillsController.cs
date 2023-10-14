using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;

namespace HumanResourcesManagementAPI.Controllers
{
    public class HardSkillsController : Controller<HardSkill>
    {
        public HardSkillsController(IRepository<HardSkill> repository) : base(repository)
        {
        }
    }
}
