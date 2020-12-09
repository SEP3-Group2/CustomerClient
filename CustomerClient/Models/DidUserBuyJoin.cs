using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class DidUserBuyJoin
    {
        [JsonPropertyName("transactionid")]
        public int transactionid {get; set; }
        [JsonPropertyName("email")]
        public String email { get; set; }
        [JsonPropertyName("productid")]
        public int productid { get; set; }
    }
}
