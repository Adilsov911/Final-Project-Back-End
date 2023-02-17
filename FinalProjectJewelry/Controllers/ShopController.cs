using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Models;
using FinalProjectJewelry.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;
        public ShopController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int pageIndex)
        {
            ShopVM shopVM = new ShopVM
            {
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                Products = _context.Products.Where(p => p.IsDeleted == false).OrderByDescending(b=>b.Id).ToList(),
                Colors = _context.Colors.Where(c => c.IsDeleted == false).ToList(),
                Sizes = _context.Sizes.Where(c => c.IsDeleted == false).ToList()
            };

            int totalPages = (int)Math.Ceiling((decimal)shopVM.Products.Count()/7);
            if (pageIndex<1||pageIndex>totalPages)
            {
                pageIndex = 1;
            }
           
            shopVM.Products = shopVM.Products.Skip((pageIndex - 1) * 3).Take(8).ToList();
            ViewBag.totalpages = totalPages;
            ViewBag.pageIndex = pageIndex;

            return View(shopVM);
        }

        public IActionResult Detail(int? id)
        {


            ProductVM productVM = new ProductVM
            {
                Product = _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Where(p => p.IsDeleted == false && p.Id == id).Include(p => p.ProductImages).Include(s => s.Brand).FirstOrDefault(),
                Comments = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList(),
            };
            Product product = _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Where(p => p.IsDeleted == false && p.Id == id).Include(p=>p.ProductImages).Include(s=>s.Brand).FirstOrDefault();


            return View(productVM);
        }
        public async Task<IActionResult> Search(string search)
        {
            List<Product> products = await _context.Products.Where(p => !p.IsDeleted && p.Title.ToLower().Contains(search.ToLower())).ToListAsync();
            return PartialView("_SearchPartial", products);

        }

    }
}

