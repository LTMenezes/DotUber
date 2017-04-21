using DotUber.ResponseModels.RideEstimates;
using DotUber.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace DotUber.Services
{
    public static class EstimateService
    {
        public static EstimatePriceList GetPriceEstimate(this Uber uberProvider, double startLatitude, double startLongitude, double endLatitude, double endLongitude)
        {
            var request = CreateGetPriceEstimateRequest(uberProvider, startLatitude, startLongitude, endLatitude, endLongitude);
            var responseBody = Uber.HttpClient.SendAsync(request).Result.GetBody();
            return JsonConvert.DeserializeObject<EstimatePriceList>(responseBody);
        }

        public static EstimateTimeList GetTimeEstimate(this Uber uberProvider, double startLatitude, double startLongitude)
        {
            var request = CreateGetTimeEstimateRequest(uberProvider, startLatitude, startLongitude);
            var responseBody = Uber.HttpClient.SendAsync(request).Result.GetBody();
            return JsonConvert.DeserializeObject<EstimateTimeList>(responseBody);
        }

        private static HttpRequestMessage CreateGetPriceEstimateRequest(Uber uberProvider, double startLatitude, double startLongitude, double endLatitude, double endLongitude)
        {
            string productHttpUrl = string.Format(UberEndpoints.GetPriceEstimateEndpoint, startLatitude, startLongitude, endLatitude, endLongitude);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(productHttpUrl),
                Method = HttpMethod.Get
            };
            RequestUtils.ConfigureGetHttpRequestHeaders(ref request, uberProvider);
            return request;
        }

        private static HttpRequestMessage CreateGetTimeEstimateRequest(Uber uberProvider, double startLatitude, double startLongitude)
        {
            string productHttpUrl = string.Format(UberEndpoints.GetTimeEstimateEndpoint, startLatitude, startLongitude);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(productHttpUrl),
                Method = HttpMethod.Get
            };
            RequestUtils.ConfigureGetHttpRequestHeaders(ref request, uberProvider);
            return request;
        }
    }
}
