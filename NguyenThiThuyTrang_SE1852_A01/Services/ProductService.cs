using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductResponsitory();
        }
        public bool DeleteProduct(int id)
        {
            return iProductRepository.DeleteProduct(id);
        }

        public Product? GetById(int id)
        {
            return iProductRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        public void InitializeDataset()
        {
            iProductRepository.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return iProductRepository.SaveProduct(p);
        }

        public List<Product> SearchByName(string keyword)
        {
            return iProductRepository.SearchByName(keyword);
        }

        public bool UpdateProduct(Product p)
        {
            return iProductRepository.UpdateProduct(p);
        }
    }
}
