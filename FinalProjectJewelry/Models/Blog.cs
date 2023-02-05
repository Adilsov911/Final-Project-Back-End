using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string AtohorName { get; set; }
        public DateTime Time { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
