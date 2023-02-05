using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Areas.Manage.ViewModels.Account
{
    public class ProfileVM
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Compare(nameof(NewPassword))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
