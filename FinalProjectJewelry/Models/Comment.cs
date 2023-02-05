using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class Comment : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 300)]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool IsAccess { get; set; }

        public int? BlogId { get; set; }
        public Blog Blog { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
