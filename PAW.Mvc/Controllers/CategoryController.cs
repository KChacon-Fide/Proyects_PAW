using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAW.Business;
using PAW.Data.Models;


namespace PAW.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager;

        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryManager.GetCategoriesAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryManager category)
        {
            if (ModelState.IsValid)
            {
                await _categoryManager.AddCategoryAsync(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
