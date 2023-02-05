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


            ProductVM productVM = new ProductVM
            {
                Product = _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Where(p => p.IsDeleted == false && p.Id == id).Include(p => p.ProductImages).Include(s => s.Brand).FirstOrDefault(),
                Comments = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList(),
            };
            Product product = _context.Products.Include(p => p.ProductTags).ThenInclude(pt => pt.Tag).Include(p => p.ProductSizes).ThenInclude(ps => ps.Size).Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Where(p => p.IsDeleted == false && p.Id == id).Include(p=>p.ProductImages).Include(s=>s.Brand).FirstOrDefault();


            return View(product);
        }
        public async Task<IActionResult> Search(int? id, string search)
        {
            IEnumerable<ProductListVM> products = await _context.Products
                    .Where(
                    p => id != null ? p.CategoryId == id : true &&
                    p.Title.ToLower().Contains(search.ToLower()) ||
                    p.Brand.Name.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(p => p.Id)
                    .Take(3)
                    .Select(x => new ProductListVM
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Image = x.MainImage
                    })
                    .ToListAsync();

            

            return PartialView("_SearchPartial", products);
        }
        [Authorize]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Details", "Shop", new { id = comment.BlogId });
            if (!_context.Products.Any(f => f.Id == comment.ProductId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                ProductId = comment.ProductId,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true,
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Shop", new { id = comment.ProductId });

        }
        [Authorize]
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Shop");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.ProductId });
        }
    }
}

