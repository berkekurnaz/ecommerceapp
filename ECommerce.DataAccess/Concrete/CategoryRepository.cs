using ECommerce.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Concrete
{
    public class CategoryRepository : BaseMongoRepository<Category>
    {
        public CategoryRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }
    }
}
