using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    interface IRatingService
    {
        Task<List<Rating>> GetAllRatings();
        Task AddRating(Rating rating);
        Task<List<DidUserBuyJoin>> DidUserBuyThisProduct(String email);
    }
}
