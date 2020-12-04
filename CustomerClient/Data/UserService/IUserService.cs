using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string Email, string password);
        Task AddUserAsync(User user);

        void setBool(bool comingFromDelivery);
        bool getBool();
        
    }
}
