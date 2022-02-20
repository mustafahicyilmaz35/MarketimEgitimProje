using Marketim.Business.Abstracts;
using Marketim.DataAccess.Abstacts;
using Marketim.DataAccess.Concretes.EfConcretes;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Concretes
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        //ICategoryRepository categoryRepository = new CategoryRepository();
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {

        }
    }
}
