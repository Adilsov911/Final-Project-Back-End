using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Category : BaseEntity 
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
