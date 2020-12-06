using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string email, string password);
        Task AddUserAsync(User user);
        Task<User> getUserByIdAsync(int id);
        Task<User> UpadteUserAsync(User user);
        void setUserId(int id);
        int getUserId();
    }
}
