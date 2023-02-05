using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
