using LabWebApp.Models;
using LabWebApp.Controllers;
namespace LabWebApp.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_PropertiesSetCorrectly()

        {

            // Arrange

            var product = new Product

            {

                Id = 1,

                Name = "Test Product",

                Price = 9.99m,

                Description = "Test product description"

            };

            // Act

            // (No action needed for this test.)

            // Assert

            Assert.Equal(1, product.Id);

            Assert.Equal("Test Product", product.Name);

            Assert.Equal(9.99m, product.Price);

            Assert.Equal("Test product description", product.Description);

        }


        [Fact]
        public void Product_PriceFormattedCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Id = 3,
                Name = "Currency Test Product",
                Price = 49.99m,
                Description = "Currency format test product"
            };

            // Act
            string formattedPrice = product.Price.ToString("C");

            // Assert
            Assert.Equal("$49.99", formattedPrice);  
        }

        [Fact]
        public void Calculate_VolumeOfCylinder()
        {
            double r = 3.2;
            double h = 7.1;
            double volume = 3.141 * r * r * h;
            volume = Math.Round(volume, 2);
            double expectedVolume = 228.36;
            Assert.Equal(expectedVolume, volume);
        }
    }
}