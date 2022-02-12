using Marketim.Entity.Abstracts;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Abstacts
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
