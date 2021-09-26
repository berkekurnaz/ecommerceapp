using ECommerce.Business.Concrete;
using ECommerce.Models.Concrete;
using ECommerce.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {

        ProductManager _productManager { get; set; }
        CategoryManager _categoryManager { get; set; }

        public ProductController(ProductManager productManager, CategoryManager categoryManager)
        {
            this._productManager = productManager;
            this._categoryManager = categoryManager;
        }

        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] string title = "", [FromQuery] string description = "", [FromQuery] int min = 0, [FromQuery] int max = 0, [FromQuery] string category = "")
        {
            try
            {
                var products = _productManager.GetAllProductsBySearch(title: title, description: description, min: min, max: max);
                List<ProductReponseDTO> result = new List<ProductReponseDTO>();
                foreach (var item in products)
                {
                    var findCategory = _categoryManager.GetCategory(item.Category.ToString());
                    if (findCategory != null)
                    {
                        result.Add(new ProductReponseDTO
                        {
                            Id = item.Id.ToString(),
                            Title = item.Title,
                            Description = item.Description,
                            StockQuantity = item.StockQuantity.ToString(),
                            Category = new CategoryResponseDTO
                            {
                                Id = findCategory.Id.ToString(),
                                Title = findCategory.Title,
                                Description = findCategory.Description
                            },
                        });
                    }
                }
                if (category != null && category.Length >= 1)
                {
                    result = result.Where(x => x.Category.Title == category).ToList();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("{productId}")]
        public IActionResult GetProductById([FromRoute] string productId)
        {
            try
            {
                var findProduct = _productManager.GetProduct(productId);
                var result = new ProductReponseDTO(); 
                if (findProduct != null)
                {
                    var findCategory = _categoryManager.GetCategory(findProduct.Category.ToString());
                    if (findCategory != null)
                    {
                        result.Id = findProduct.Id.ToString();
                        result.Title = findProduct.Title;
                        result.Description = findProduct.Description;
                        result.StockQuantity = findProduct.StockQuantity.ToString();
                        result.Category = new CategoryResponseDTO
                        {
                            Id = findCategory.Id.ToString(),
                            Title = findCategory.Title,
                            Description = findCategory.Description
                        };
                    }
                    return Ok(result);
                }
                else
                {
                    return StatusCode(404);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult AddNewProduct([FromBody] ProductRequestDTO productRequestDTO)
        {
            try
            {
                var state = _productManager.AddProduct(new Product
                {
                    Title = productRequestDTO.Title,
                    Description = productRequestDTO.Description,
                    StockQuantity = Convert.ToInt32(productRequestDTO.StockQuantity),
                    Category = MongoDB.Bson.ObjectId.Parse(productRequestDTO.Category),
                });
                if (state)
                {
                    return Ok(productRequestDTO);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpPut("{productId}")]
        public IActionResult UpdateProduct([FromRoute] string productId, [FromBody] ProductRequestDTO productRequestDTO)
        {
            try
            {
                var findProduct = _productManager.GetProduct(productId);
                if (findProduct == null)
                {
                    return StatusCode(204);
                }
                findProduct.Title = productRequestDTO.Title;
                findProduct.Description = productRequestDTO.Description;
                findProduct.StockQuantity = Convert.ToInt32(productRequestDTO.StockQuantity);
                findProduct.Category = MongoDB.Bson.ObjectId.Parse(productRequestDTO.Category);
                var state = _productManager.UpdateProduct(productId, findProduct);
                if (state)
                {
                    return Ok(productRequestDTO);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct([FromRoute] string productId)
        {
            try
            {
                return Ok(_productManager.DeleteProduct(productId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

    }
}
