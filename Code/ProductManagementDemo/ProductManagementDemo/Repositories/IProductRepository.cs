using BusinessObjects;
using Repositories.Payload.Response;

namespace Repositories;

public interface IProductRepository
{
    void SaveProduct(Product product);
    void DeleteProduct(Product product);
    void UpdateProduct(Product product);
    List<ProductResponse> GetProducts();
    Product GetProductById(int productId);
}