using System;
using System.Collections.Generic;
using System.Text;

namespace DotUber.Utils
{
    public static class UberEndpoints
    {
        private static string productEndpoint = "https://api.uber.com/v1.2/products?latitude={0}&longitude={1}";
        public static string GetProductEndpoint { get { return productEndpoint; } }

        private static string productDetailEndpoint = "https://api.uber.com/v1.2/products/{0}";
        public static string GetProductDetailEndpoint { get { return productDetailEndpoint; } }

        private static string timeEstimateEndpoint = "https://api.uber.com/v1.2/estimates/time?start_latitude={0}&start_longitude={1}";
        public static string GetTimeEstimateEndpoint { get { return timeEstimateEndpoint; } }

        private static string priceEstimateEndpoint = "https://api.uber.com/v1.2/estimates/price?start_latitude={0}&start_longitude={1}&end_latitude={2}&end_longitude={3}";
        public static string GetPriceEstimateEndpoint { get { return priceEstimateEndpoint; } }

        private static string authorizeUrl = "https://login.uber.com/oauth/v2/authorize?client_id={0}&response_type=code";
        public static string GetAuthorizeUrl { get { return authorizeUrl; } }

        private static string accessTokenUrl = "https://login.uber.com/oauth/v2/token";
        public static string GetAcessTokenUrl { get { return accessTokenUrl; } }
    }
}
