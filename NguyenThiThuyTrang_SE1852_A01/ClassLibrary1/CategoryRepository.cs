using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public bool AddCategory(Category c)
        {
            return categoryDAO.AddCategory(c);
        }

        public bool DeleteCategory(int cid)
        {
            return categoryDAO.DeleteCategory(cid);
        }

        public List<Category> GetCategory()
        {
            return categoryDAO.GetCategory();
        }

        public void InitializeDataset()
        {
            categoryDAO.InitializeDataset();
        }

        public List<Category> SearchCategoryByName(string keyword)
        {
            return categoryDAO.SearchCategoryByName(keyword);
        }

        public bool UpdateCategory(Category c)
        {
            return categoryDAO.UpdateCategory(c);
        }
    }
}
