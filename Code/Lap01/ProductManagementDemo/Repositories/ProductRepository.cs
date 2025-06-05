using BusinessObjects;
using DataAccessObjects;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product p) => ProductDao.DeleteProduct(p);
        public void SaveProduct(Product p) => ProductDao.SaveProduct(p);
        public void UpdateProduct(Product p) => ProductDao.UpdateProduct(p);
        public List<Product> GetProducts() => ProductDao.GetProducts();
        public Product GetProductById(int id) => ProductDao.GetProductById(id);
    }
}
