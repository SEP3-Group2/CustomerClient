using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<IList<Product>> GetTitleCategoryPriceFilteredProductsAsync(string title, string category,string price);
    }
}
