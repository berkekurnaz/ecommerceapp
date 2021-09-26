using ECommerce.Models.Concrete;
using MongoDB.Bson;
using System.Collections.Generic;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetAllProductsBySearch(string title = "", string description = "", int min = 0, int max = 0);
        List<Product> GetProductsByCategory(ObjectId Id);
        Product GetProduct(string Id);
        bool AddProduct(Product model);
        bool UpdateProduct(string Id, Product model);
        bool DeleteProduct(string Id);
    }
}
