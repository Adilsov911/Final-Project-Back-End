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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            BlogVM homeVM = new BlogVM
            {
                Blogs = await _context.Blogs.Where(s => s.IsDeleted == false).ToListAsync()
                
            };

            return View(homeVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);
            return View(blog);
        }
    }
}
