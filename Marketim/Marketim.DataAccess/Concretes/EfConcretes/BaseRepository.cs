using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.EfConcretes
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : Model, new()
        where TContext : DbContext, new()
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
