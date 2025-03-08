using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        // List of products
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 800 },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 600 },
            new Product { Name = "Tablet", Category = "Electronics", Price = 400 },
            new Product { Name = "Chair", Category = "Furniture", Price = 150 },
            new Product { Name = "Table", Category = "Furniture", Price = 250 },
            new Product { Name = "Shirt", Category = "Clothing", Price = 50 },
            new Product { Name = "Jeans", Category = "Clothing", Price = 80 }
        };

        // Filter products by a specific category ...
        string selectedCategory = "Electronics";
        var filteredProducts = products.Where(p => p.Category == selectedCategory);

        Console.WriteLine($"Products in category '{selectedCategory}':");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"- {product.Name}, Price: ${product.Price}");
        }

        // Calculate and display average price of products in each category
        var averagePrices = products.GroupBy(p => p.Category)
                                    .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.Price) });

        Console.WriteLine("\nAverage Price of Products in Each Category:");
        foreach (var category in averagePrices)
        {
            Console.WriteLine($"{category.Category}: ${category.AveragePrice:F2}");
        }
    }
}
