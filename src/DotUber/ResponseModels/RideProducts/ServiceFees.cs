using Newtonsoft.Json;

namespace DotUber.ResponseModels.RideProducts
{
    public class ServiceFees
    {
        [JsonProperty("fee")]
        public decimal Fee { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
