using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    interface ICloudService
    {
        Task<string> GetStringAsync();
        Task<List<Product>> GetAllProductsAsync();
    }
}
