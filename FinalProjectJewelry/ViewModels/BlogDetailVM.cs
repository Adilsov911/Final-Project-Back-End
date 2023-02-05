using FinalProjectJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.ViewModels
{
    public class BlogDetailVM
    {
    
            public Blog Blog { get; set; }
            public List<Blog> Blogs { get; set; }
            public List<Comment> Comments { get; set; }
      
    }
}
