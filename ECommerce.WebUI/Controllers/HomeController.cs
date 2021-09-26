using ECommerce.Business.Concrete;
using ECommerce.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {

        ProductManager _productManager { get; set; }
        CategoryManager _categoryManager { get; set; }

        public HomeController(ProductManager productManager, CategoryManager categoryManager)
        {
            this._productManager = productManager;
            this._categoryManager = categoryManager;
        }

        public IActionResult Index([FromQuery] string categoryId = "all")
        {
            var products = _productManager.GetAllProducts();
            if (categoryId != null && categoryId != "all")
            {
                products = _productManager.GetProductsByCategory(MongoDB.Bson.ObjectId.Parse(categoryId));
            }
            ViewBag.FindCategories = _categoryManager.GetAllCategories();
            return View(products);
        }

        public IActionResult AddProduct()
        {
            ViewBag.FindCategories = _categoryManager.GetAllCategories();
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product, string Category)
        {
            product.Category = MongoDB.Bson.ObjectId.Parse(Category);
            var state = _productManager.AddProduct(product);
            if (state == true)
            {
                TempData["MsgSuccess"] = "You succesfully created a new product.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["MsgError"] = "Error";
                return View();
            }
        }

        public IActionResult UpdateProduct(string Id)
        {
            var findProduct = _productManager.GetProduct(Id);
            ViewBag.FindCategories = _categoryManager.GetAllCategories();
            ViewBag.FindCategory = _categoryManager.GetCategory(findProduct.Category.ToString());
            return View(findProduct);
        }

        [HttpPost]
        public IActionResult UpdateProduct(string Id, Product product, string Category)
        {
            var findProduct = _productManager.GetProduct(Id);
            if (findProduct == null)
            {
                return RedirectToAction("Error", "Home");
            }
            findProduct.Title = product.Title;
            findProduct.Description = product.Description;
            findProduct.Category = MongoDB.Bson.ObjectId.Parse(Category);
            findProduct.StockQuantity = product.StockQuantity;
            var state = _productManager.UpdateProduct(Id, findProduct);
            if (state == true)
            {
                TempData["MsgSuccess"] = "Product updated succesfully.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["MsgError"] = "Error";
                return View();
            }
        }

        public IActionResult DeleteProduct(string Id)
        {
            _productManager.DeleteProduct(Id);
            TempData["MsgSuccess"] = "You succesfully deleted product.";
            return RedirectToAction("Index");
        }

    }
}
