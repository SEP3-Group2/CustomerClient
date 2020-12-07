using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CustomerClient.Models;

namespace CustomerClient.Data
{
    public class WarehouseService : IWarehouseService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/warehouseproducts";

        public WarehouseService()
        {
            client = new HttpClient();
        }

        public async Task<List<Product>> GetAllProductsFromStore(int storeid)
        {
            string message = await client.GetStringAsync(uri + "/" + storeid);
            List<Product> result = JsonSerializer.Deserialize<List<Product>>(message);
            return result;
        }

        public async Task<List<CartProduct>> GetWarehouseProductFromStore(int productid, int quantity)
        {
            string message = await client.GetStringAsync(uri + "/" + productid + "/" + quantity);
            List<CartProduct> result = JsonSerializer.Deserialize<List<CartProduct>>(message);
            return result;
        }

        
    }
}
