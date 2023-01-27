using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<ProductColor> ProductColors { get; set; }
    }
}
