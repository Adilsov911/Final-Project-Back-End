using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Extension;
using FinalProjectJewelry.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.Where(b => b.IsDeleted == false).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Alreade Exists");
                return View(category);
            }


            if (category.File != null)
            {

                if (!category.File.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                category.Image = category.File.SaveImg(_env.WebRootPath, "assest/img/category");
            }

            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            category.CreatedBy = "System";

            await _context.Categories.AddAsync(category);
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

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            ViewBag.Categories = await _context.Categories
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (category.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Alreade Exists");
                return View(category);
            }

            Category existedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            if (category.File != null)
            {
                if (!category.File.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!category.File.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assest/img/category", existedCategory.Image);
                existedCategory.Image = category.File.SaveImg(_env.WebRootPath, "assest/img/category");


            }

            existedCategory.Name = category.Name.Trim();
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

            Category category = await _context.Categories
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Id Yanlisdir");
            }



            category.IsDeleted = true;
            category.DeletedBy = "";
            category.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
