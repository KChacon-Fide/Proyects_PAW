using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using PAW.Data.Repository;

namespace PAW.Business
{
    public interface IProductManager
    {
        IEnumerable<Product> CreateProduct();
    }

    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));

        }
        public IEnumerable<Product> CreateProduct()
        {
            var products = new List<Product>();
            return _productRepository.ReadAsync().Result;
        }

	}
}
