﻿using BusinessObjects;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class ProductDao
    {
        private static List<Product> listProducts;
        public ProductDao() 
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "aniseed", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };

        }
        // public List<Product> GetProducts()
        // {
        //     return listProducts;
        // }
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e) { }
            return listProducts;
        }
        public static void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }
        public static void UpdateProduct(Product product) 
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitInStock = product.UnitInStock;
                    p.CategoryId = product.CategoryId;
                }
            }
        }
        public static void DeleteProduct(Product product)
        {
            foreach(Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(p);
                }
            }
        }
        public static Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
