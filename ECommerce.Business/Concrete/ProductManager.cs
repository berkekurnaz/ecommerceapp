using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Models.Concrete;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {

        private ProductRepository _productRepository;

        public ProductManager(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProduct(Product model)
        {
            if (model.Title != null && model.Title.Length > 0 && model.Title.Length <= 200 && model.StockQuantity >= 0)
            {
                _productRepository.AddModel(model);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(string Id)
        {
            _productRepository.DeleteModel(Id);
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetAllProductsBySearch(string title = "", string description = "", int min = 0, int max = 0)
        {
            var result = _productRepository.GetAll();

            if (title != null && title.Length >= 2)
            {
                result = result.Where(x => x.Title.Contains(title)).ToList();
            }

            if (description != null && description.Length >= 2)
            {
                result = result.Where(x => x.Description.Contains(description)).ToList();
            }

            if (min != 0 && min > 0)
            {
                result = result.Where(x => x.StockQuantity > min).ToList();
            }

            if (max != 0 && max > 0)
            {
                result = result.Where(x => x.StockQuantity < max).ToList();
            }

            return result;
        }

        public Product GetProduct(string Id)
        {
            return _productRepository.GetById(Id);
        }

        public List<Product> GetProductsByCategory(ObjectId categoryId)
        {
            return _productRepository.GetAll().Where(x => x.Category == categoryId).ToList();
        }

        public bool UpdateProduct(string Id, Product model)
        {
            _productRepository.UpdateModel(Id, model);
            return true;
        }

    }
}
