using Marketim.Business.Abstracts;
using Marketim.DataAccess.Abstacts;
using Marketim.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Business.Concretes
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }
    }
}
