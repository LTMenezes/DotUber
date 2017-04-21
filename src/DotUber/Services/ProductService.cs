using DotUber.ResponseModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using DotUber.Utils;
using DotUber.ResponseModels.RideProducts;
using System.Net.Http;
using System;

namespace DotUber.Services
{
    public static class ProductService
    {
        public static ProductList GetProducts(this Uber uberProvider, double latitude, double longitude)
        {
            var request = CreateGetProductRequest(uberProvider, latitude, longitude);
            var responseBody = Uber.HttpClient.SendAsync(request).Result.GetBody();
            return JsonConvert.DeserializeObject<ProductList>(responseBody);
        }

        public static Product GetProductDetail(this Uber uberProvider, string productId)
        {
            var request = CreateGetProductDetailRequest(uberProvider, productId);
            var responseBody = Uber.HttpClient.SendAsync(request).Result.GetBody();
            return JsonConvert.DeserializeObject<Product>(responseBody);
        }

        private static HttpRequestMessage CreateGetProductRequest(Uber uberProvider, double latitude, double longitude)
        {
            string productHttpUrl = string.Format(UberEndpoints.GetProductEndpoint, latitude, longitude);
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(productHttpUrl),
                Method = HttpMethod.Get
            };
            RequestUtils.ConfigureGetHttpRequestHeaders(ref request, uberProvider);
            return request;
        }

        private static HttpRequestMessage CreateGetProductDetailRequest(Uber uberProvider, string productId)
        {
            string productHttpUrl = string.Format(UberEndpoints.GetProductDetailEndpoint, productId);
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
