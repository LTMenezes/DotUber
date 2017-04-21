using Newtonsoft.Json;
using System.Collections.Generic;

namespace DotUber.ResponseModels.RideProducts
{
    public class ProductList
    {
        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }
}
