using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Repositories
{
    public interface IBasicRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
