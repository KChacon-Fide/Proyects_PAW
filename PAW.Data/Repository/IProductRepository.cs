using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PAW.Data.Models;
using System.Threading.Tasks;

namespace PAW.Data.Repository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<IEnumerable<Product>> GetProductsWithCategoryAndSupplierAsync();
    }
}
