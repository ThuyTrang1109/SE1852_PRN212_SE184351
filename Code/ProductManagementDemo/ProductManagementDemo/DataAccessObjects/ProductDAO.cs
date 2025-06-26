using BusinessObjects;

namespace DataAccessObjects;

public class ProductDAO
{
    private static List<Product> listProducts;
    private static ProductDAO _instance;

    public ProductDAO()
    {
        Product chai = new Product(1, "Chai", 3, 12, 18);
        Product chang = new Product(2, "Chang", 1, 23, 19);
        Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
        listProducts = new List<Product>()
        {
            chai, chang, aniseed
        };
        /*Product chef = new Product(4, "Chef Anton's cajun Seasoning", 2, 34, 22);
        Product chefMix = new Product(5, "Chef Anton's Gumbo Mix", 2, 45, 34);*/
    }
    
    public static ProductDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ProductDAO();
            }
            return _instance;
        }
    }
    
    
    public List<Product> GetProducts()
    {
        return listProducts;
    }

    /*public static List<Product> GetProducts()
    {
        var listProducts = new List<Product>();
        try
        {
            using var db = new MyStoreContext();
            listProducts = db.Products.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return listProducts;
    }*/

    public void SaveProduct(Product product)
    {
        listProducts.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        foreach (Product item in listProducts.ToList())
        {
            if (item.ProductId == product.ProductId)
            {
                item.ProductId = product.ProductId;
                item.ProductName = product.ProductName;
                item.CategoryId = product.CategoryId;
                item.UnitPrice = product.UnitPrice;
                item.UnitsInStock = product.UnitsInStock;
            }
        }
    }

    public void DeleteProduct(Product product)
    {
        foreach (Product item in listProducts.ToList())
        {
            if (item.ProductId == product.ProductId)
            {
                listProducts.Remove(item);
            }
        }
    }

    public Product GetProductById(int productId)
    {
        foreach (Product item in listProducts.ToList())
        {
            if (item.ProductId == productId)
            {
                return item;
            }
        }

        return null;
    }
}
