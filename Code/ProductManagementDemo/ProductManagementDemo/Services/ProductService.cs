using BusinessObjects;
using Repositories;
using Repositories.Payload.Response;

namespace Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void SaveProduct(Product product) => _productRepository.SaveProduct(product);

    public void DeleteProduct(Product product) => _productRepository.DeleteProduct(product);

    public void UpdateProduct(Product product) => _productRepository.UpdateProduct(product);

    public List<ProductResponse> GetProducts() => _productRepository.GetProducts();

    public Product GetProductById(int productId) => _productRepository.GetProductById(productId);
}