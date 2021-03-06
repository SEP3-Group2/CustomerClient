﻿using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public class CloudUserService : IUserService
    {
        private int userId;

        HttpClient client;
        string uri = "http://localhost:8080/customerUsers";

        private bool comingFromDelivery = false;
        private bool cartHidden = false;
        private bool orderHidden = true;

        public CloudUserService()
        {
            client = new HttpClient();
        }

        public void setBool(bool comingFromDelivery)
        {
            this.comingFromDelivery = comingFromDelivery;
        }

        public bool getBool()
        {
            return comingFromDelivery;
        }


        public async Task AddUserAsync(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);

            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PostAsync($"{uri}", content);
        }


        public async Task<User> ValidateUser(string email, string password)
        {
            string message = await client.GetStringAsync($"{uri}/{email}");

            User result = JsonSerializer.Deserialize<User>(message);

            if (result == null)
            {
                throw new Exception("User not found");
            }

            if (!result.Password.Equals(password))
            {
                throw new Exception("Password is incorrect");
            }

            return result;
        }

        public async Task<User> getUserByIdAsync(int id)
        {
            string message = await client.GetStringAsync($"{uri}/users/{id}");
            User result = JsonSerializer.Deserialize<User>(message);
            return result;
        }
        public async Task<User> UpadteUserAsync(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PatchAsync(uri, content);
            var getUser = await getUserByIdAsync(user.UserID);
            return getUser;
        }

        public void setUserId(int id)
        {
            userId = id;
        }

        public int getUserId()
        {
            return userId;
        }
    }
}
