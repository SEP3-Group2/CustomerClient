using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class Rating
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]

        public String name { get; set; }
        [JsonPropertyName("star")]

        public int star { get; set; }
        [JsonPropertyName("comment")]

        public String comment { get; set; }
        [JsonPropertyName("productid")]
        public int productid { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
