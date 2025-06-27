using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public void InitializeDataset();
        public Product? GetById(int id);
        public bool SaveProduct(Product p);
        public bool UpdateProduct(Product p);
        public bool DeleteProduct(int id);
        public List<Product> SearchByName(string keyword);
    }
}
