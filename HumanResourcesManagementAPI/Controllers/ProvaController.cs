using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesManagementAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProvaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Test", "Controller", "Data" };
        }
    }
}
