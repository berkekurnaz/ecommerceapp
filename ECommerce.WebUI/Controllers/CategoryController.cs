using ECommerce.Business.Concrete;
using ECommerce.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager _categoryManager { get; set; }

        public CategoryController(CategoryManager categoryManager)
        {
            this._categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            return View(_categoryManager.GetAllCategories());
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            var state = _categoryManager.AddCategory(category);
            if (state == true)
            {
                TempData["MsgSuccess"] = "You succesfully created a new category.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["MsgError"] = "Error";
                return View();
            }
        }

        public IActionResult UpdateCategory(string Id)
        {
            return View(_categoryManager.GetCategory(Id));
        }

        [HttpPost]
        public IActionResult UpdateCategory(string Id, Category category)
        {
            var findCategory = _categoryManager.GetCategory(Id);
            if (findCategory == null)
            {
                return RedirectToAction("Error", "Home");
            }
            findCategory.Title = category.Title;
            findCategory.Description = category.Description;
            _categoryManager.UpdateCategory(Id, findCategory);
            TempData["MsgSuccess"] = "Category updated succesfully.";
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(string Id)
        {
            _categoryManager.DeleteCategory(Id);
            TempData["MsgSuccess"] = "You succesfully deleted category.";
            return RedirectToAction("Index");
        }
    }
}
