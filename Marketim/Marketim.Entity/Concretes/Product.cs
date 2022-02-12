using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marketim.Entity.Concretes
{
    public class Product : Model
    {
        
        public string ProductName { get; set; }
        public int StockCount { get; set; }
        public decimal UnitPrice { get; set; }

        //Navigation Property
        public virtual Category Category { get; set; }
    }
}
