
using Microsoft.EntityFrameworkCore;
using WarehouseAccountingBlazor.Entity;
using WarehouseAccountingBlazor.Entity.Entities;

namespace WarehouseAccountingBlazor.Repositories
{
    public class BasicRepository<T> : IBasicRepository<T> where T : class, IEntity
    {
        private readonly WarehouseAccountingDbContext _context;

        public BasicRepository(WarehouseAccountingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            var list = await _context.Set<T>().ToListAsync();
            return list;
        }

        public async Task<T?> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
