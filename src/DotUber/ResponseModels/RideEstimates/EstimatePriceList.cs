using Newtonsoft.Json;
using System.Collections.Generic;

namespace DotUber.ResponseModels.RideEstimates
{
    public class EstimatePriceList
    {
        [JsonProperty("prices")]
        public List<EstimatePriceDetails> EstimatePriceDetails { get; set; }
    }
}
