using ECommerce.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Abstract
{
    public interface IBaseMongoRepository<T> where T : MongoBaseModel
    {

        /// <summary>
        /// This method is list your table's records.
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// This method is find record with Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id);

        /// <summary>
        /// This method is insert new record in your table.
        /// </summary>
        /// <param name="model"></param>
        void AddModel(T model);

        /// <summary>
        /// This method is first find record then update that record.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        void UpdateModel(string id, T model);

        /// <summary>
        /// This method is delete record in your table.
        /// </summary>
        /// <param name="id"></param>
        void DeleteModel(string id);

    }
}
