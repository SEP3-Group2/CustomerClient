﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CustomerClient.Models;

namespace CustomerClient.Data
{
    public class TransactionProductService : ITransactionProductService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/transactionProduct";

        public TransactionProductService()
        {
            client = new HttpClient();
        }

        public async Task AddTransactionProductAsync(TransactionProduct transactionProduct)
        {
            string userSerialized = JsonSerializer.Serialize(transactionProduct);

            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PostAsync($"{uri}", content);
        }
    }
}
