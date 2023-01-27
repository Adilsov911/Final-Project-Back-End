using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Size : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<ProductSize> ProductSizes { get; set; }
    }
}
