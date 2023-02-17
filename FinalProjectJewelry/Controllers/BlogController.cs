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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            BlogVM homeVM = new BlogVM
            {
                Blogs = await _context.Blogs.Where(s => s.IsDeleted == false).ToListAsync()
                
            };

            return View(homeVM);
        }
        public IActionResult Detail(int? id)
        {
            BlogDetailVM detailVM = new BlogDetailVM
            {
                Blogs = _context.Blogs.Include(b => b.Comments).ThenInclude(b => b.AppUser).ToList(),
                Blog = _context.Blogs.Include(b => b.Comments).ThenInclude(b => b.AppUser).FirstOrDefault(b => b.Id == id),
                Comments = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList(),
            };

            return View(detailVM);
        }
        [Authorize]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            if (!_context.Blogs.Any(f => f.Id == comment.BlogId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                BlogId = comment.BlogId,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true,
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        
        }
        [Authorize]
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        }
    }
}
