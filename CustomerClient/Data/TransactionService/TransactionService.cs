using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CustomerClient.Models;

namespace CustomerClient.Data
{
    public class TransactionService : ITransactionService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/transaction";

        public TransactionService()
        {
            client = new HttpClient();
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            string userSerialized = JsonSerializer.Serialize(transaction);

            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PostAsync($"{uri}", content);
        }

        public async Task<int> GetLastTransactiontID()
        {
            Console.WriteLine("getting id");
            string message = await client.GetStringAsync(uri + "/1/1/1");
            return JsonSerializer.Deserialize<int>(message);
        }

        public async Task<List<Transaction>> getTransactionsByEmail(string email)
        {
            string message = await client.GetStringAsync(uri + "/" + email);
            List<Transaction> returnList = JsonSerializer.Deserialize<List<Transaction>>(message);
            return returnList;
        }
    }
}
