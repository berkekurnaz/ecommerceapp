using ECommerce.DataAccess.Abstract;
using ECommerce.Models.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Concrete
{
    public class BaseMongoRepository<T> : IBaseMongoRepository<T> where T : MongoBaseModel
    {

        private readonly IMongoCollection<T> mongoCollection;

        public BaseMongoRepository(string mongoDbConnectionString, string dbName, string collectionName)
        {
            var client = new MongoClient(mongoDbConnectionString);
            var database = client.GetDatabase(dbName);
            mongoCollection = database.GetCollection<T>(collectionName);
        }

        public List<T> GetAll()
        {
            return mongoCollection.Find(book => true).ToList();
        }

        public T GetById(string id)
        {
            var documentId = new ObjectId(id);
            return mongoCollection.Find(x => x.Id == documentId).FirstOrDefault();
        }

        public void AddModel(T model)
        {
            mongoCollection.InsertOne(model);
        }

        public void UpdateModel(string id, T model)
        {
            var documentId = new ObjectId(id);
            mongoCollection.ReplaceOne(x => x.Id == documentId, model);
        }

        public void DeleteModel(string id)
        {
            var documentId = new ObjectId(id);
            mongoCollection.DeleteOne(x => x.Id == documentId);
        }

    }
}
