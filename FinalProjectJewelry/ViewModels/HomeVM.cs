using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Brand> Brands { get; set; }


    }
}
