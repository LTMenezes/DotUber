using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotUber.ResponseModels.RideProducts
{
    public class ProductPriceDetails
    {
        [JsonProperty("service_fees")]
        public List<ServiceFees> ServiceFees { get; set; }

        [JsonProperty("cost_per_minute")]
        public decimal CostPerMinute { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("minimum")]
        public decimal Minimum { get; set; }

        [JsonProperty("cost_per_distance")]
        public decimal CostPerDistance { get; set; }

        [JsonProperty("base")]
        public decimal Base { get; set; }

        [JsonProperty("cancellation_fee")]
        public decimal CancellationFee { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
