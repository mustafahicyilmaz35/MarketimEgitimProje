using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marketim.DataAccess.Concretes.EfConcretes
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : Model, new()
        where TContext : DbContext, new()
    {
        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Func<T, bool> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(filter).FirstOrDefault();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
