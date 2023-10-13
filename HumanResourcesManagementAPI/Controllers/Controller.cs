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
        [HttpGet]
        public Task<List<T>> GetAll()
        {
            return repository.GetAll();
        }
        [HttpGet("{id:int}")]
        public Task<T?> GetById(int id)
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
