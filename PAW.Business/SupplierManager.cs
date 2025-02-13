using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models;   
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PAW.Business;
using PAW.Data.Repository;


    public class SupplierManager
    {
        private readonly IRepositoryBase<Supplier> _supplierRepository;

        public SupplierManager(IRepositoryBase<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
        {
            return await _supplierRepository.ReadAsync();
        }

        public async Task<bool> AddSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.CreateAsync(supplier);
        }
    }

