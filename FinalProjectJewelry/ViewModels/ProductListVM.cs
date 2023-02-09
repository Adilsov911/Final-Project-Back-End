using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public List<Category> Categories { get; set; }
    }
}
