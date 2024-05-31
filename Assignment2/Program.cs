<<<<<<< HEAD
﻿using Assignment2;class Program
{
    static void Main(string[] args)
    {
        // Create a new Product instance
        Product product = new Product(123, "Test Product", 9.99m, 100);

        // Display the initial product details
        Console.WriteLine($"Product ID: {product.ProductID}");
        Console.WriteLine($"Product Name: {product.ProductName}");
        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine($"Stock: {product.Stock}");

        // Increase the stock
        product.IncreaseStock(50);
        Console.WriteLine($"Stock after increase: {product.Stock}");

        // Decrease the stock
        product.DecreaseStock(25);
        Console.WriteLine($"Stock after decrease: {product.Stock}");

        Console.ReadLine();
    }
}
=======
﻿
>>>>>>> f6c56aab8ba8b3cc3d8f1fbe747abd329832378a
