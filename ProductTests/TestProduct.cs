using System;
using NUnit.Framework;
using Assignment2;
namespace ProductTests

{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void Constructor_ValidInput_SetsPropertiesCorrectly()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.AreEqual(productID, product.ProductID);
            Assert.AreEqual(productName, product.ProductName);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(stock, product.Stock);
        }

        [TestCase(0)]
        [TestCase(1001)]
        public void ProductID_OutOfRange_ThrowsArgumentException(int productID)
        {
            // Arrange
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(productID, productName, price, stock));
        }

        [TestCase(1)]
        [TestCase(1000)]
        public void ProductID_ValidRange_SetsPropertyCorrectly(int productID)
        {
            // Arrange
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.AreEqual(productID, product.ProductID);
        }

        [Test]
        public void ProductName_NullOrEmpty_ThrowsArgumentException()
        {
            // Arrange
            int productID = 123;
            string productName = null;
            decimal price = 9.99m;
            int stock = 100;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(productID, productName, price, stock));

            // Arrange
            productName = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(productID, productName, price, stock));
        }

        [Test]
        public void ProductName_ValidString_SetsPropertyCorrectly()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.AreEqual(productName, product.ProductName);
        }

        [TestCase(0.99)]
        [TestCase(5000.01)]
        public void Price_OutOfRange_ThrowsArgumentException(decimal price)
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            int stock = 100;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(productID, productName, price, stock));
        }

        [TestCase(1.00)]
        [TestCase(5000.00)]
        public void Price_ValidRange_SetsPropertyCorrectly(decimal price)
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            int stock = 100;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        [TestCase(0)]
        [TestCase(1001)]
        public void Stock_OutOfRange_ThrowsArgumentException(int stock)
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Product(productID, productName, price, stock));
        }

        [TestCase(1)]
        [TestCase(1000)]
        public void Stock_ValidRange_SetsPropertyCorrectly(int stock)
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;

            // Act
            Product product = new Product(productID, productName, price, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void IncreaseStock_ValidQuantity_IncreasesStockCorrectly()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;
            int increaseQuantity = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.IncreaseStock(increaseQuantity);

            // Assert
            Assert.AreEqual(stock + increaseQuantity, product.Stock);
        }

        [Test]
        public void IncreaseStock_ZeroQuantity_DoesNotChangeStock()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;
            int increaseQuantity = 0;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.IncreaseStock(increaseQuantity);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void DecreaseStock_ValidQuantity_DecreasesStockCorrectly()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;
            int decreaseQuantity = 50;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.DecreaseStock(decreaseQuantity);

            // Assert
            Assert.AreEqual(stock - decreaseQuantity, product.Stock);
        }

        [Test]
        public void DecreaseStock_ZeroQuantity_DoesNotChangeStock()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;
            int decreaseQuantity = 0;
            Product product = new Product(productID, productName, price, stock);

            // Act
            product.DecreaseStock(decreaseQuantity);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void DecreaseStock_InsufficientStock_ThrowsInvalidOperationException()
        {
            // Arrange
            int productID = 123;
            string productName = "Test Product";
            decimal price = 9.99m;
            int stock = 100;
            int decreaseQuantity = 150;
            Product product = new Product(productID, productName, price, stock);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(decreaseQuantity));
        }
    }
}