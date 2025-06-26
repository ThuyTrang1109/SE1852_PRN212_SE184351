using BusinessObjects;
using DataAccessObjects;
using Repositories.Payload.Response;

namespace Repositories;

public class ProductRepository: IProductRepository
{
    public void SaveProduct(Product product) => ProductDAO.Instance.SaveProduct(product);

    public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);

    public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);

    public List<ProductResponse> GetProducts()
    {
        var products = ProductDAO.Instance.GetProducts();
        var categories = CategoryDAO.Instance.GetCategories();
        List<ProductResponse> productResponses = new List<ProductResponse>();
        foreach (var product in products)
        {
            ProductResponse productResponse = new ProductResponse();
            foreach (var category in categories)
            {
                if (product.CategoryId == category.CategoryId)
                {
                    productResponse.CategoryName = category.CategoryName;
                    break;
                }
            }
            productResponse.ProductName = product.ProductName;
            productResponse.ProductId = product.ProductId;
            productResponse.UnitPrice = product.UnitPrice;
            productResponse.UnitsInStock = product.UnitsInStock;
            productResponses.Add(productResponse);
        }
        return productResponses;
    }

    public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);
}