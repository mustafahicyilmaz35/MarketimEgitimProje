using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marketim.Entity.Abstracts
{
    public abstract class Model
    {
        [Key]
        public int Id { get; set; }
    }
}
