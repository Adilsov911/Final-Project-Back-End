using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string ProfilImg { get; set; }
        [NotMapped]
        public AppUser ProfilFiles { get; set; }

      
    }
}
