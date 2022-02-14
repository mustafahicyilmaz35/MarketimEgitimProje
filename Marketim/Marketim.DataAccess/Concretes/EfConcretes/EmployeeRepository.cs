using Marketim.DataAccess.Abstacts;
using Marketim.DataAccess.Concretes.Contexts;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.EfConcretes
{
    public class EmployeeRepository : BaseRepository<Employee, MarketimContext>, IEmployeeRepository
    {
    }
}
