using BusinessObjects;
using Repositories;
using System.Collections.Generic;


namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService _iProductService;
        public ProductService()
        {
            _iProductService = new ProductService();
        }
        public void DeleteProduct(Product p)
        {
            _iProductService.DeleteProduct(p);
        }
        public Product GetProductById(int id)
        {
            return _iProductService.GetProductById(id);
        }
        public List<Product> GetProducts()
        {
            return _iProductService.GetProducts();
        }
        public void SaveProduct(Product p)
        {
            _iProductService.SaveProduct(p);
        }
        public void UpdateProduct(Product p)
        {
            _iProductService.UpdateProduct(p);
        }
    }
}
