using Marketim.Business.Abstracts;
using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Concretes
{
    public class BaseService<T> : IBaseService<T> where T : Model, new()
    {

        readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Delete(T entity)
        {
            _baseRepository.Delete(entity);
        }

        public T Get(Func<T, bool> filter)
        {
            return _baseRepository.Get(filter);
        }

        public List<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public void Insert(T entity)
        {
            _baseRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }
    }
}
