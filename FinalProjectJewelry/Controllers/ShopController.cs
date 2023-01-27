using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Models;
using FinalProjectJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                Products = _context.Products.Where(p => p.IsDeleted == false).ToList(),
                Colors = _context.Colors.Where(c => c.IsDeleted == false).ToList(),
                Sizes = _context.Sizes.Where(c => c.IsDeleted == false).ToList()
            };

            return View(shopVM);
        }

        public IActionResult Detail(int? id)
        {


            Product product = _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Where(p => p.IsDeleted == false && p.Id == id).Include(p=>p.ProductImages).Include(s=>s.Brand).FirstOrDefault();


            return View(product);
        }

    }
}
