using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public class InMemoryUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            
            users = new[] {
                new User {
                    Password = "123456",
                    Email = "Kevin"
                },
                new User {
                    Password = "123456",
                    Email = "Anett"
                }
            }.ToList();
            
        }

        public Task AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> ValidateUser(string email, string password)
        {            
            User first = users.FirstOrDefault(user => user.Email.Equals(email));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}
