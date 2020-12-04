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
        Task<Product> GetProductByIdAsync(int id);
        void setProductId(int id);
        int getProductId();
        void addProductToCart(ProductQuantity product, int quantity);
        List<ProductQuantity> getProductsFromCart();
        void RemoveProductFromCart(ProductQuantity product);
        List<string> getTitles();
        void RemoveTitle(ProductQuantity product);
    }
}
