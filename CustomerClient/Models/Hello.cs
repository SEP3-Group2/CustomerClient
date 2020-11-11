using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class Hello
    {
        [Required]
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
