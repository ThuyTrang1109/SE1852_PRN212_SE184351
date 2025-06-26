using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICategoryService
    {
        public void InitializeDataset();
        public List<Category> GetCategory();
        public bool AddCategory(Category c);
        public bool UpdateCategory(Category c);
        public bool DeleteCategory(int cid);
        public List<Category> SearchCategoryByName(string keyword);
    }
}
