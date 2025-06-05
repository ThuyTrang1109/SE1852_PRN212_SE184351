using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _iCategoryService;
        public CategoryService()
        {
            _iCategoryService = new CategoryService();
        }
        public List<Category> GetCategories()
        {
            return _iCategoryService.GetCategories();
        }
    }
}
