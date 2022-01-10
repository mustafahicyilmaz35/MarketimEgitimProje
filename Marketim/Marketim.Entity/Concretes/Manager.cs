using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Entity.Concretes
{
    public class Manager : Model
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //foreign key
        public int EmployeeId { get; set; }

        //Navigation Property
        public virtual HashSet<Employee> Employees { get; set; }

        public Manager()
        {
            Employees = new HashSet<Employee>();
        }
    }
}
