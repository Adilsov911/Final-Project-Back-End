using FinalProjectJewelry.DAL;
using FinalProjectJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Blogs = _context.Blogs.Where(s => s.IsDeleted == false).ToList(),
                Sliders = _context.Sliders.Where(s => s.IsDeleted == false).ToList(),
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                Products = _context.Products.Where(p => p.IsDeleted == false).ToList(),
                Brands = _context.Brands.Where(p => p.IsDeleted == false).ToList()

            };

            return View(homeVM);
        }
    }
}
