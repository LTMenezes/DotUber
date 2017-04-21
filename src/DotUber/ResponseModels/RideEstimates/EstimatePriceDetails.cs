using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotUber.ResponseModels.RideEstimates
{
    public class EstimatePriceDetails
    {
        [JsonProperty("localized_display_name")]
        public string LocalizedDisplayName { get; set; }

        [JsonProperty("distance")]
        public float Distance { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("high_estimate")]
        public decimal HighEstimate { get; set; }

        [JsonProperty("low_estimate")]
        public decimal LowEstimate { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("estimate")]
        public string Estimate { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("minimum")]
        public decimal Minimum { get; set; }

        [JsonProperty("surge_multiplier")]
        public float SurgeMultiplier { get; set; }
    }
}
