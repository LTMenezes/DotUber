using DotUber;
using DotUber.ResponseModels.RideEstimates;
using DotUber.ResponseModels.RideProducts;
using DotUber.Services;
using System;
using Xunit;

namespace ServicesTest.cs
{
    public class EstimatePriceTest
    {
        [Fact]
        public void EstimatePriceEndpointShouldReturnNonEmptyPriceEstimateList()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var priceEstimateList = uber.GetPriceEstimate(-22.9192815, -43.2400531, -22.9217786, -43.2189619);

            //Assert
            Assert.NotEmpty(priceEstimateList.EstimatePriceDetails);
        }

        [Fact]
        public void EstimatePriceEndpointShouldReturnTimeEstimateListWithDefaultPropertiesFilled()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var priceEstimateList = uber.GetPriceEstimate(-22.9192815, -43.2400531, -22.9217786, -43.2189619);

            //Assert
            foreach (EstimatePriceDetails estimatePriceDetail in priceEstimateList.EstimatePriceDetails)
            {
                Assert.NotNull(estimatePriceDetail.DisplayName);
                Assert.NotNull(estimatePriceDetail.Minimum);
                Assert.NotNull(estimatePriceDetail.ProductId);
                Assert.NotNull(estimatePriceDetail.LowEstimate);
                Assert.NotNull(estimatePriceDetail.HighEstimate);
            }
        }
    }
}
