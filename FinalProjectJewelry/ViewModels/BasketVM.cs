﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class BasketVM
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
