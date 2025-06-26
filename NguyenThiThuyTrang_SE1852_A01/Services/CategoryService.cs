using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryService : ICategoryService
     {
        private readonly ICategoryRepository iCategoryRepository;

        public bool AddCategory(Category c)
        {
            return iCategoryRepository.AddCategory(c);
        }

        public bool DeleteCategory(int cid)
        {
            return iCategoryRepository.DeleteCategory(cid);
        }

        public List<Category> GetCategory()
        {
            return iCategoryRepository.GetCategory();
        }

        public void InitializeDataset()
        {
            iCategoryRepository.InitializeDataset();
        }

        public List<Category> SearchCategoryByName(string keyword)
        {
            return iCategoryRepository.SearchCategoryByName(keyword);
        }

        public bool UpdateCategory(Category c)
        {
            return iCategoryRepository.UpdateCategory(c);
        }
    }
}
