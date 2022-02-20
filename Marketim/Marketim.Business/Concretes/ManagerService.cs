using Marketim.Business.Abstracts;
using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Concretes
{
    public class ManagerService : BaseService<Manager>, IManagerService
    {
        public ManagerService(IManagerRepository managerRepository): base(managerRepository)
        {

        }
    }
}
