using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual Category? Category { get; set; }

        // Constructor template
        public Product(int id, string name, int? categoryId, int? unitsInStock, decimal? price)
        {
            this.ProductId = id;
            this.ProductName = name;
            this.CategoryId = categoryId;
            this.UnitsInStock = unitsInStock;
            this.UnitPrice = price;
        }

        public Product()
        {
            
        }
    }
}
