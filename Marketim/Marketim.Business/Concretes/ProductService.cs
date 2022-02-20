using Marketim.Business.Abstracts;
using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Concretes
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {

        }
    }
}
