using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; private set; }

        // Constructor
        public Product(int productID, string productName, decimal price, int stock)
        {
<<<<<<< HEAD
            if (productID < 1 || productID > 1000)
                throw new ArgumentException("ProductID must be between 1 and 1000.");

            if (string.IsNullOrEmpty(productName))
                throw new ArgumentException("ProductName cannot be null or empty.");

            if (price < 1 || price > 5000)
                throw new ArgumentException("Price must be between $1 and $5000.");

            if (stock < 1 || stock > 1000)
                throw new ArgumentException("Stock must be between 1 and 1000.");

=======
>>>>>>> f6c56aab8ba8b3cc3d8f1fbe747abd329832378a
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Methods
<<<<<<< HEAD
        public void IncreaseStock(int quantity)
=======
        public void IncreasedStock(int quantity)
>>>>>>> f6c56aab8ba8b3cc3d8f1fbe747abd329832378a
        {
            Stock += quantity;
        }

<<<<<<< HEAD
        public void DecreaseStock(int quantity)
=======
        public void DecreasedStock(int quantity)
>>>>>>> f6c56aab8ba8b3cc3d8f1fbe747abd329832378a
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
            }
            else
            {
                throw new InvalidOperationException("Insufficient stock.");
            }
        }
    }
<<<<<<< HEAD

=======
>>>>>>> f6c56aab8ba8b3cc3d8f1fbe747abd329832378a
}
