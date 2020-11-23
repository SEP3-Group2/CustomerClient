using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public class ProductService : IProductService
    {
        HttpClient client;

        public ProductService()
        {
            client = new HttpClient();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            string message = await client.GetStringAsync("http://localhost:8080/products");

            List<Product> returnList = JsonSerializer.Deserialize<List<Product>>(message);

            return returnList;
        }
    }
}
