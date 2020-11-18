using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        Task AddUserAsync(User user);
    }
}
