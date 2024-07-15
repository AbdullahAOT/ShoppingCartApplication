using Xunit;
using System.Runtime.CompilerServices;
using ShoppingCartApplication;
namespace ShoppingCartTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddItem_ShouldAddProductToCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.0m, ProductCategory.Food);

            // Act
            cart.AddItem(product);

            // Assert
            Assert.Contains(product, cart.ViewItems());
        }

        [Fact]
        public void RemoveItem_ShouldRemoveProductFromCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.0m, ProductCategory.Food);
            cart.AddItem(product);

            // Act
            cart.RemoveItem(product);

            // Assert
            Assert.DoesNotContain(product, cart.ViewItems());
        }

        [Fact]
        public void CalculateTotalCost_ShouldReturnSumOfProductPrices()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product("Test Product 1", 10.0m, ProductCategory.Food);
            var product2 = new Product("Test Product 2", 20.0m, ProductCategory.Clothing);
            cart.AddItem(product1);
            cart.AddItem(product2);

            // Act
            var totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(30.0m, totalCost);
        }

        [Fact]
        public void AddItem_ShouldIncreaseTotalCost()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.0m, ProductCategory.Food);
            var initialTotalCost = cart.CalculateTotalCost();

            // Act
            cart.AddItem(product);
            var newTotalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(initialTotalCost + 10.0m, newTotalCost);
        }

        [Fact]
        public void RemoveItem_ShouldDecreaseTotalCost()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.0m, ProductCategory.Food);
            cart.AddItem(product);
            var initialTotalCost = cart.CalculateTotalCost();

            // Act
            cart.RemoveItem(product);
            var newTotalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(initialTotalCost - 10.0m, newTotalCost);
        }
    }
}