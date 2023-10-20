using HumanResourcesManagementAPI.Models.Classi;
using HumanResourcesManagementAPI.Models.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsController : ControllerBase
    {
        private IRepositoryBenefits repository;

        public BenefitsController(IRepositoryBenefits repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public Task<Benefits> Create(Benefits entity)
        {
            return repository.Create(entity);
        }
        [HttpGet]
        public  async Task<IActionResult> GetAll()
        {
            var result = await repository.GetAll();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public Task<Benefits?> GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpDelete("{id:int}")]
        public Task DeleteById(int id)
        {
            return repository.DeleteById(id);
        }
    }
}
