using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Extension;
using FinalProjectJewelry.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Areas.Manage.Controllers
{
        [Area("manage")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.Where(b => b.IsDeleted == false).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Blog = _context.Blogs.Where(c => c.IsDeleted == false).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            ViewBag.Blog = await _context.Blogs
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blog);
            }

            if (await _context.Blogs.AnyAsync(c => c.IsDeleted == false && c.Title.ToLower() == blog.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {blog.Title} Alreade Exists");
                return View(blog);
            }


            if (blog.BlogImageFile != null)
            {

                if (!blog.BlogImageFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                blog.Image = blog.BlogImageFile.SaveImg(_env.WebRootPath, "assest/img/blog");
            }

            blog.Title = blog.Title.Trim();
            blog.AtohorName = blog.AtohorName;
            blog.Time = DateTime.UtcNow.AddHours(4);
            blog.IsDeleted = false;
            blog.DeletedAt = DateTime.UtcNow.AddHours(4);
            blog.CreatedBy = "System";

            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (blog == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Blog = await _context.Blogs
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            ViewBag.Blog = await _context.Blogs
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(blog);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (blog.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Blogs.AnyAsync(c => c.IsDeleted == false && c.Title.ToLower() == blog.Title.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {blog.Title} Alreade Exists");
                return View(blog);
            }

            Blog existedCategory = await _context.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            if (blog.BlogImageFile != null)
            {
                if (!blog.BlogImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!blog.BlogImageFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assest/img/blog", existedCategory.Image);
                existedCategory.Image = blog.BlogImageFile.SaveImg(_env.WebRootPath, "assest/img/blog");


            }

            existedCategory.Title = blog.Title.Trim();
            existedCategory.Description = blog.Description.Trim();
            existedCategory.AtohorName = blog.AtohorName.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            Blog blog = await _context.Blogs
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (blog == null)
            {
                return NotFound("Id Yanlisdir");
            }



            blog.IsDeleted = true;
            blog.DeletedBy = "System";
            blog.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
