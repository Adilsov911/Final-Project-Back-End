using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile BrandFile { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
