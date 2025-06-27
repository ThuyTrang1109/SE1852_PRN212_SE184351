using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductResponsitory : IProductRepository
    {
        ProductDAO productsDAO = new ProductDAO();
        public List<Product> GetProducts()
        {
            return productsDAO.GetProducts();
        }

        public void InitializeDataset()
        {
            productsDAO.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productsDAO.SaveProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return productsDAO.UpdateProduct(p);
        }

        public bool DeleteProduct(int id)
        {
            return productsDAO.DeleteProduct(id);
        }

        public Product? GetById(int id)
        {
            return productsDAO.GetById(id);
        }

        public List<Product> SearchByName(string keyword)
        {
            return productsDAO.SearchByName(keyword);
        }
    }
}
