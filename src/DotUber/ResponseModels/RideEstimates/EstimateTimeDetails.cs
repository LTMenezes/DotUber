using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotUber.ResponseModels.RideEstimates
{
    public class EstimateTimeDetails
    {
        [JsonProperty("localized_display_name")]
        public string LocalizedDisplayName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("estimate")]
        public int EstimateSeconds { get; set; }
    }
}
