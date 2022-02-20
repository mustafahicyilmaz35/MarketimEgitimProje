using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Abstracts
{
    public interface IBaseService<T> where T : Model, new()
    {
        List<T> GetAll();
        T Get(Func<T, bool> filter); //LINQ

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
