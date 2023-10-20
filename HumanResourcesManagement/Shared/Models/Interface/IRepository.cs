namespace HumanResourcesManagementAPI.Models.Interface
{
    public interface IRepository<T> where T : class
    {

        Task<T> Create(T entity);
        Task Update(T entity);
        Task DeleteById(int id);
        Task<List<T>> GetAll();
        Task<T?> GetById(int id);

    }
}
