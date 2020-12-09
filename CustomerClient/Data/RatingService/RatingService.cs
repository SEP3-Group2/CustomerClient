using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public class RatingService : IRatingService
    {
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public RatingService()
        {
            this.client = new HttpClient();
        }

        public async Task AddRating(Rating rating)
        {
            string ratingAsJson = JsonSerializer.Serialize(rating);
            HttpContent content = new StringContent(ratingAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/ratings", content);
        }

        public async Task<List<Rating>> GetAllRatings()
        {
            string message = await client.GetStringAsync(uri + "/ratings");
            List<Rating> returnList = JsonSerializer.Deserialize<List<Rating>>(message);
            return returnList;
        }

        public async Task<List<DidUserBuyJoin>> DidUserBuyThisProduct(string email)
        {

            string message = await client.GetStringAsync(uri + "/ratings/"+email);
            List<DidUserBuyJoin> returnList = JsonSerializer.Deserialize<List<DidUserBuyJoin>>(message);
            return returnList;
        }
    }
}
