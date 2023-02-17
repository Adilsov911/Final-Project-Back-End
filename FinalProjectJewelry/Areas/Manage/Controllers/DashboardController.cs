using FinalProjectJewelry.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize (Roles ="Admin,SuperAdmin")]
    public class DashboardController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public DashboardController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {

            IEnumerable<AppUser> appUsers = _userManager.Users.ToList();
            return View(appUsers);
        }
    }
}
