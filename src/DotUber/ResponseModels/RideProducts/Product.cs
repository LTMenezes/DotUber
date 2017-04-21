using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotUber.ResponseModels.RideProducts
{
    public class Product
    {
        [JsonProperty("upfront_fare_enabled")]
        public bool UpfrontFareEnabled { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("price_details")]
        public ProductPriceDetails PriceDetails { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("cash_enabled")]
        public bool CashEnabled { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("product_group")]
        public string ProductGroup { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
