using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models.Concrete
{
    public class Product : MongoBaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("StockQuantity")]
        public int StockQuantity { get; set; }

        [BsonElement("Category")]
        public ObjectId Category { get; set; }

    }
}
