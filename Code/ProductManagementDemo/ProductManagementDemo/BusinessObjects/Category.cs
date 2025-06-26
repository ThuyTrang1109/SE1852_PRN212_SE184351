namespace BusinessObjects;

public partial class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public virtual ICollection<Product> Products { get; set; }
    public Category()
    {
        Products = new HashSet<Product>();
    }

    public Category(int categoryId, string categoryName)
    {
        this.CategoryId = categoryId;
        this.CategoryName = categoryName;
    }
}