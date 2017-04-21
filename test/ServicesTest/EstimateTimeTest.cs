using DotUber;
using DotUber.ResponseModels.RideEstimates;
using DotUber.Services;
using System;
using Xunit;

namespace ServicesTest.cs
{
    public class EstimateTimeTest
    {
        [Fact]
        public void EstimateTimeEndpointShouldReturnNonEmptyTimeEstimateList()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var timeEstimateList = uber.GetTimeEstimate(-22.9192815, -43.2400531);

            //Assert
            Assert.NotEmpty(timeEstimateList.EstimateTimeDetails);
        }

        [Fact]
        public void EstimatePriceEndpointShouldReturnTimeEstimateListWithDefaultPropertiesFilled()
        {
            //Arrange
            var uber = new Uber(Environment.GetEnvironmentVariable("uber-secret"));

            //Act
            var timeEstimateList = uber.GetTimeEstimate(-22.9192815, -43.2400531);

            //Assert
            foreach (EstimateTimeDetails estimatePrice in timeEstimateList.EstimateTimeDetails)
            {
                Assert.NotNull(estimatePrice.DisplayName);
                Assert.NotNull(estimatePrice.EstimateSeconds);
                Assert.NotNull(estimatePrice.ProductId);
            }
        }
    }
}
