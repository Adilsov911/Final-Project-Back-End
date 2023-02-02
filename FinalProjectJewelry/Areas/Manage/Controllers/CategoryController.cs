using FinalProjectJewelry.DAL;
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
                    if (category.File.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("File", "Fayl Tipi .jpg ve ya .jpeg olmalidir");
                        return View(category);
                    }

                    if ((category.File.Length / 2024) > 50)
                    {
                        ModelState.AddModelError("File", "Fayl Olcusu maksimum 20 kb olmalidir");
                        return View(category);
                    }

                    //string path = @"C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\wwwroot\assets\images\";

                    string path = Path.Combine(_env.WebRootPath, "assets", "img");

                    string oldPath = Path.Combine(path, existedCategory.Image);

                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    string fileName = Guid.NewGuid().ToString() + "-" + DateTime.UtcNow.AddHours(4).ToString("yyyyMMddHHmmss") + "-" + category.File.FileName;

                    string fullpath = Path.Combine(path, fileName);

                    using (FileStream fileStream = new FileStream(fullpath, FileMode.Create))
                    {
                        await category.File.CopyToAsync(fileStream);
                    }

                  
                    existedCategory.Image = fileName;
                }
            
           

              
                
            

           
            existedCategory.Name = category.Name.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
