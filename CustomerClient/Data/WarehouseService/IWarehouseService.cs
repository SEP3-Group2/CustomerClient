using CustomerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerClient.Data
{
    public interface IWarehouseService
    {
        Task<List<Product>> GetAllProductsFromStore(int storeid);
        Task<List<CartProduct>> GetWarehouseProductFromStore(int productid, int quantity);
        Task<List<CartProduct>> GetNotWarehouseProductFromStore(int productid, int quantity);
    }
}
