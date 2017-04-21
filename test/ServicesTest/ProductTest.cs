using DotUber;
using DotUber.ResponseModels.RideProducts;
using DotUber.Services;
using System;
using Xunit;

namespace ServicesTest.cs
{
    public class ProductTest
    {
        [Fact]
        public void ProductEndpointShouldReturnNonEmptyProducts()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var productList = uber.GetProducts(-22.9192815, -43.2400531);

            //Assert
            Assert.NotEmpty(productList.Products);
        }

        [Fact]
        public void ProductEndpointShouldReturnProductsWithDefaultPropertiesFilled()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var productList = uber.GetProducts(-22.9192815, -43.2400531);

            //Assert
            foreach (Product product in productList.Products)
            {
                Assert.NotNull(product.DisplayName);
                Assert.NotNull(product.ProductId);
            }
        }
    }
}
