using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerClient.Models
{
    public class User
    {
        [JsonPropertyName("userID")]
        public int UserID { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("birthday")]
        public DateTime Birthday { get; set; }

        public bool Equals(User user)
        {
            return
                   UserID == user.UserID &&
                   Email == user.Email &&
                   Password == user.Password &&
                   Name == user.Name &&
                   Address == user.Address &&
                   Phone == user.Phone &&
                   Birthday == user.Birthday;
        }
    }

   
}
