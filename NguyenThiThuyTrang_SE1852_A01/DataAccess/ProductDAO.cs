using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void InitializeDataset()
        {
            if (products.Count == 0)
            {
                products.Add(new Product { ProductId = 1, ProductName = "Coca", SupplierId = 1, CategoryId = 1, QuantityPerUnit = "24 cans", UnitPrice = 200, UnitsInStock = 10, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
                products.Add(new Product { ProductId = 2, ProductName = "Pepsi", SupplierId = 2, CategoryId = 1, QuantityPerUnit = "12 cans", UnitPrice = 180, UnitsInStock = 15, UnitsOnOrder = 5, ReorderLevel = 7, Discontinued = false });
                products.Add(new Product { ProductId = 3, ProductName = "Sprite", SupplierId = 3, CategoryId = 1, QuantityPerUnit = "12 cans", UnitPrice = 160, UnitsInStock = 20, UnitsOnOrder = 10, ReorderLevel = 8, Discontinued = false });
                products.Add(new Product { ProductId = 4, ProductName = "Fanta", SupplierId = 4, CategoryId = 1, QuantityPerUnit = "12 cans", UnitPrice = 150, UnitsInStock = 12, UnitsOnOrder = 6, ReorderLevel = 5, Discontinued = false });
                products.Add(new Product { ProductId = 5, ProductName = "Mountain Dew", SupplierId = 5, CategoryId = 1, QuantityPerUnit = "12 cans", UnitPrice = 210, UnitsInStock = 8, UnitsOnOrder = 0, ReorderLevel = 4, Discontinued = true });
                products.Add(new Product { ProductId = 6, ProductName = "7 Up", SupplierId = 6, CategoryId = 1, QuantityPerUnit = "12 cans", UnitPrice = 190, UnitsInStock = 18, UnitsOnOrder = 2, ReorderLevel = 6, Discontinued = false });
                products.Add(new Product { ProductId = 7, ProductName = "Schweppes", SupplierId = 7, CategoryId = 1, QuantityPerUnit = "6 bottles", UnitPrice = 250, UnitsInStock = 5, UnitsOnOrder = 0, ReorderLevel = 3, Discontinued = false });
                products.Add(new Product { ProductId = 8, ProductName = "Red Bull", SupplierId = 8, CategoryId = 1, QuantityPerUnit = "6 cans", UnitPrice = 400, UnitsInStock = 7, UnitsOnOrder = 3, ReorderLevel = 2, Discontinued = true });
                products.Add(new Product { ProductId = 9, ProductName = "Tonic Water", SupplierId = 9, CategoryId = 2, QuantityPerUnit = "10 bottles", UnitPrice = 180, UnitsInStock = 12, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false });
                products.Add(new Product { ProductId = 10, ProductName = "Gatorade", SupplierId = 10, CategoryId = 2, QuantityPerUnit = "6 bottles", UnitPrice = 300, UnitsInStock = 25, UnitsOnOrder = 10, ReorderLevel = 15, Discontinued = false });
            }
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product? GetById(int id) =>
            products.FirstOrDefault(p => p.ProductId == id);

        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == p.ProductId);
            if (old != null)
                return false;//thêm mới thất bại
            products.Add(p);//thêm mới thành công
            return true;
        }

        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == p.ProductId);
            if (old == null)
                return false; // sửa thất bại (không tìm thấy)
            old.ProductName = p.ProductName;
            old.SupplierId = p.SupplierId;
            old.CategoryId = p.CategoryId;
            old.QuantityPerUnit = p.QuantityPerUnit;
            old.UnitPrice = p.UnitPrice;
            old.UnitsInStock = p.UnitsInStock;
            old.UnitsOnOrder = p.UnitsOnOrder;
            old.ReorderLevel = p.ReorderLevel;
            old.Discontinued = p.Discontinued;
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.ProductId == id);
            if (old == null)
                return false; // xóa thất bại (không tìm thấy)
            products.Remove(old);
            return true;
        }

        public List<Product> SearchByName(string keyword) =>
            products.Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
