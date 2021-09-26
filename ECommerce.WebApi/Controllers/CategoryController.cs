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
    public class CategoryController : Controller
    {

        CategoryManager _categoryManager { get; set; }

        public CategoryController(CategoryManager categoryManager)
        {
            this._categoryManager = categoryManager;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            List<CategoryResponseDTO> result = new List<CategoryResponseDTO>();
            foreach (var item in _categoryManager.GetAllCategories())
            {
                result.Add(new CategoryResponseDTO { 
                    Id = item.Id.ToString(),
                    Title = item.Title,
                    Description = item.Description
                });
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddNewCategory([FromBody] CategoryRequestDTO categoryRequestDTO)
        {
            try
            {
                var state = _categoryManager.AddCategory(new Category
                {
                    Title = categoryRequestDTO.Title,
                    Description = categoryRequestDTO.Description
                });
                if (state)
                {
                    return Ok(categoryRequestDTO);
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

        [HttpDelete("{categoryId}")]
        public IActionResult DeleteCategory([FromRoute] string categoryId)
        {
            try
            {
                return Ok(_categoryManager.DeleteCategory(categoryId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }


    }
}
