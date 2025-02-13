using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAW.Data.Models; // Asegura que IRepositoryBase<> esté disponible
using System.Collections.Generic;
using System.Threading.Tasks;
using PAW.Data.Repository;


namespace PAW.Business
{
    public class CategoryManager
    {
        private readonly IRepositoryBase<Category> _categoryRepository;

        public CategoryManager(IRepositoryBase<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.ReadAsync();
        }

        public async Task<bool> AddCategoryAsync(Category category)
        {
            return await _categoryRepository.CreateAsync(category);
        }

        public async System.Threading.Tasks.Task AddCategoryAsync(CategoryManager category)
        {
            throw new NotImplementedException();
        }
    }
}
