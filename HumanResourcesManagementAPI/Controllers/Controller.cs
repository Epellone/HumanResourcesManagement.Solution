using HumanResourcesManagementAPI.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller<T> : ControllerBase where T: class
    {
        private IRepository<T> repository;

        public Controller(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public Task<T> Create(T entity)
        {
            return repository.Create(entity);
            
        }

        [HttpPut]
        public async Task<IActionResult> Update(T entity)
        {
            await repository.Update(entity);
            return Ok(entity);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await repository.GetAll();
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public Task<T?> GetById(Guid id)
        {
            return repository.GetById(id);
        }

        [HttpDelete("{id:Guid}")]
        public Task DeleteById(Guid id)
        {
            return repository.DeleteById(id);
        }
    }
}
