using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class ShopVM
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
