﻿using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class HeaderVM
    {
      
            public Dictionary<string, string> Settings { get; set; }
            public IEnumerable<Category> Categories { get; set; }
            public IEnumerable<BasketVM> BasketVMs { get; set; }
        
    }
}
