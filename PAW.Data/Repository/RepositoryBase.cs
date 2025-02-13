using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAW.Data.Models;

namespace PAW.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ProductDbContext _context;
        protected ProductDbContext DbContext => _context;

        public RepositoryBase(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<IEnumerable<T>> ReadAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _context.Update(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _context.Remove(entity);
            return await SaveAsync();
        }

        public async Task<bool> ExistsAsync(T entity)
        {
            return await _context.Set<T>().AnyAsync(e => e.Equals(entity));
        }

        protected async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
