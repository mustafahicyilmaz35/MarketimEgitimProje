using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Entity.Concretes
{
    public class Employee : Model
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //navigation property
        public virtual Manager Manager { get; set; }
    }
}
