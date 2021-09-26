using ECommerce.Models.Concrete;
using System.Collections.Generic;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategory(string Id);
        bool AddCategory(Category model);
        bool UpdateCategory(string Id, Category model);
        bool DeleteCategory(string Id);
    }
}
