using HumanResourcesManagementAPI.Models.Interface;
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesManagementAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDBContext _dbContext;
        public Repository(ApplicationDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<T> Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteById(int id)
        {
            var entityToDelete = await GetById(id);

            if (entityToDelete != null)
            {
                _dbContext.Set<T>().Remove(entityToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


    }
}
