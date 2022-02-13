﻿using Marketim.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.Entity.Concretes
{
    public class Category : Model
    {
        public string CategoryName { get; set; }

        //Navigation Property
        public virtual HashSet<Product> Products { get; set; }  //Collection Yapıdır.
        

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
