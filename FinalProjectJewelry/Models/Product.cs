using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Product : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [DataType("money")]
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public int Count { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string MainImage { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }

        public Nullable<int> BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<ProductSize> ProductSizes { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public IEnumerable<ProductColor> ProductColors { get; set; }

        [NotMapped]
        public IFormFile MainImageFile { get; set; }
       
        [NotMapped]
        public IEnumerable<IFormFile> ProductImagesFiles { get; set; }
        [NotMapped]
        public IEnumerable<int> TagIds { get; set; }
        [NotMapped]
        public IEnumerable<int> ColorIds { get; set; }
        [NotMapped]
        public IEnumerable<int> SizeIds { get; set; }


    }
}
