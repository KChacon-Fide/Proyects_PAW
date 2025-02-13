using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PAW.Data.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<bool> CreateAsync(T entity);
        Task<IEnumerable<T>> ReadAsync();
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> ExistsAsync(T entity);
    }
}
