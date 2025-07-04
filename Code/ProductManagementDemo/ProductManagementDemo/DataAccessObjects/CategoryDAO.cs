﻿using BusinessObjects;

namespace DataAccessObjects;

public class CategoryDAO
{
    private static CategoryDAO _instance;

    public CategoryDAO()
    {
    }

    public static CategoryDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CategoryDAO();
            }

            return _instance;
        }
    }
    public List<Category> GetCategories()
    {
        Category beverages = new Category(1, "Beverages");
        Category condiments = new Category(2, "Condiments");
        Category confections = new Category(3, "Confections");
        Category dairy = new Category(4, "Dairy Products");
        Category grains = new Category(5, "Grains/Cereals");
        Category meat = new  Category(6, "Meat/Pountry");
        Category produce = new Category(7, "Produce");
        Category seafood = new Category(8, "Seafood");

        var listCategories = new List<Category>();
        try
        {
            listCategories.Add(beverages);
            listCategories.Add(condiments);
            listCategories.Add(confections);
            listCategories.Add(dairy);
            listCategories.Add(grains);
            listCategories.Add(meat);
            listCategories.Add(produce);
            listCategories.Add(seafood);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return listCategories;
    }
}