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
    public class CategoryManager : ICategoryService
    {

        private CategoryRepository _categoryRepository;

        public CategoryManager(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool AddCategory(Category model)
        {
            _categoryRepository.AddModel(model);
            return true;
        }

        public bool DeleteCategory(string Id)
        {
            _categoryRepository.DeleteModel(Id);
            return true;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategory(string Id)
        {
            return _categoryRepository.GetById(Id);
        }

        public bool UpdateCategory(string Id, Category model)
        {
            _categoryRepository.UpdateModel(Id, model);
            return true;
        }
    }
}
