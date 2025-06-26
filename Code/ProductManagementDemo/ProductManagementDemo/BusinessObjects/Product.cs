namespace BusinessObjects;

public partial class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int? CategoryId { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public virtual Category Category { get; set; }

    public Product()
    {
    }

    public Product(int productId, string productName, int categoryId, decimal unitPrice, short unitsInStock)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.CategoryId = categoryId;
        this.UnitPrice = unitPrice;
        this.UnitsInStock = unitsInStock;
    }
}