using DotUber;
using DotUber.ResponseModels.RideProducts;
using DotUber.Services;
using System;
using Xunit;

namespace ServicesTest.cs
{
    public class ProductDetailTest
    {
        [Fact]
        public void ProductDetailEndpointShouldReturnProductsWithDefaultPropertiesFilled()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var product = uber.GetProductDetail("d5ef01d9-7d54-413e-b265-425948d06e92");

            //Assert
            Assert.NotNull(product.DisplayName);
            Assert.NotNull(product.ProductId);
            Assert.NotNull(product.PriceDetails.CurrencyCode);
            Assert.NotNull(product.PriceDetails.CostPerMinute);
        }

        [Fact]
        public void ProductDetailEndpointShouldThrowExceptionWithEmptyProductId()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            Assert.ThrowsAny<Exception>(() => uber.GetProductDetail(""));
        }
    }
}
