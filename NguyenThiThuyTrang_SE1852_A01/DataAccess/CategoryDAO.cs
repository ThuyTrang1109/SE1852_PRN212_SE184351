using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        static List<Category> categories = new List<Category>();

        public void InitializeDataset()
        {
            if (categories.Count == 0)
            {
                // Categories for ProductDAO sample data
                categories.Add(new Category { CategoryId = 1, CategoryName = "Beverages", Description = "Soft drinks, sodas, etc.", Picture = null }); // Coca, Pepsi, Sprite, Fanta, Mountain Dew, 7 Up, Schweppes, Red Bull
                categories.Add(new Category { CategoryId = 2, CategoryName = "Energy & Sports Drinks", Description = "Energy and sports drinks", Picture = null }); // Tonic Water, Gatorade
                // You can add more categories if needed for other products
            }
        }

        public List<Category> GetCategory()
        {
            return categories;
        } 

        public Category? GetById(int id) =>
            categories.FirstOrDefault(c => c.CategoryId == id);

        public bool AddCategory(Category c)
        {
            Category cate = categories.FirstOrDefault(x => x.CategoryId == c.CategoryId);
            if (cate != null)
                return false;//thêm mới thất bại
            categories.Add(c);//thêm mới thành công
            return true;
        }

        public bool UpdateCategory(Category c)
        {
            Category cate = categories.FirstOrDefault(x => x.CategoryId == c.CategoryId);
            if (cate == null)
                return false; // sửa thất bại
            cate.CategoryName = c.CategoryName;
            cate.Description = c.Description;
            cate.Picture = c.Picture;
            return true;
        }

        public bool DeleteCategory(int cid)
        {
            Category cate = categories.FirstOrDefault(x => x.CategoryId == cid);
            if (cate == null)
                return false; // xóa thất bại
            categories.Remove(cate);
            return true;
        }

        public List<Category> SearchCategoryByName(string keyword) =>
            categories.Where(c => c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
