using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(1000)]
        public string MainTitle { get; set; }
        public string TitleImg { get; set; }

        public bool Right { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
      
        
    }
}
