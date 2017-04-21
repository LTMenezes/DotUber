using Newtonsoft.Json;
using System.Collections.Generic;

namespace DotUber.ResponseModels.RideEstimates
{
    public class EstimateTimeList
    {
        [JsonProperty("times")]
        public List<EstimateTimeDetails> EstimateTimeDetails { get; set; }
    }
}
