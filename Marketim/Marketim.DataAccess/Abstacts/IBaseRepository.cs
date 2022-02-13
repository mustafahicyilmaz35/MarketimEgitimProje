using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Abstacts
{
    public interface IBaseRepository<T> where T : Model,new()
    {
        //CRUD -> Create, Retreive, Update, Delete
        List<T> GetAll();
        T Get(Func<T, bool> filter); //LINQ

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
