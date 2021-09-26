using ECommerce.Models.Abstract;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models.Concrete
{
    public class MongoBaseModel : IEntity
    {
        public ObjectId Id { get; set; }
    }
}
