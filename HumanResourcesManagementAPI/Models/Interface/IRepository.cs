namespace HumanResourcesManagementAPI.Models.Interface
{
    public interface IRepository<T> where T : class
    {

        Task<T> Create(T entity);
        Task Update(T entity);
        Task DeleteById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(Guid id);

    }
}
