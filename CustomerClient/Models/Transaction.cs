using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class Transaction
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("storeid")]
        public int StoreId { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("totalPrice")]
        public double TotalPrice { get; set; }
        [Required]
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }
        [Required]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [Required]
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("deliverymethod")]
        public string DeliveryMethod { get; set; }
        [JsonPropertyName("email")]
        [Required]
        public string Email { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
