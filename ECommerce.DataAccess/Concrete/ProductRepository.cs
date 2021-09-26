using ECommerce.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Concrete
{
    public class ProductRepository : BaseMongoRepository<Product>
    {
        public ProductRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }
    }
}
