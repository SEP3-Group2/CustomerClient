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
        private string uri = "http://localhost:8080/products";
        private int productId = 0;

        public ProductService()
        {
            client = new HttpClient();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            string message = await client.GetStringAsync(uri);
            List<Product> returnList = JsonSerializer.Deserialize<List<Product>>(message);
            return returnList;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            string message = await client.GetStringAsync(uri + "/" + id);
            Product result = JsonSerializer.Deserialize<Product>(message);
            return result;
        }

       

        public async Task<IList<Product>> GetTitleCategoryPriceFilteredProductsAsync(string title, string category, string price)
        {
            string message = "";

            if (title == null)
            {
                if (category.Equals("All"))
                {
                    message = await client.GetStringAsync(uri + "/nullnull/All/" + price);
                }
                else
                {
                    message = await client.GetStringAsync(uri + "/nullnull/" + category + "/" + price);
                }
            }
            else
            {
                if (category.Equals("All"))
                {
                    message = await client.GetStringAsync(uri + "/" + title + "/All/" + price);
                }
                else
                {
                    message = await client.GetStringAsync(uri + "/" + title + "/" + category + "/" + price);
                }

            }
            List<Product> result = JsonSerializer.Deserialize<List<Product>>(message);
            return result;
        }

        public void setProductId(int id)
        {
            productId = id;
        }
        public int getProductId()
        {
            return productId;
        }
    }
}
