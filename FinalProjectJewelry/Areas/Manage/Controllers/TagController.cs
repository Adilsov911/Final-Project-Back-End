using FinalProjectJewelry.DAL;
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
    public class TagController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TagController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Tags.Where(b => b.IsDeleted == false).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.Where(c => c.IsDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tag tag)
        {
            ViewBag.Tags = await _context.Tags
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(tag);
            }

            if (await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == tag.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {tag.Name} Alreade Exists");
                return View(tag);
            }


          
            tag.Name = tag.Name.Trim();
            tag.IsDeleted = false;
            tag.DeletedAt = DateTime.UtcNow.AddHours(4);
            tag.CreatedBy = "System";

            await _context.Tags.AddAsync(tag);
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

            Tag tag = await _context.Tags.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (tag == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(tag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Tag tag)
        {
            ViewBag.Tags = await _context.Tags
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(tag);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (tag.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == tag.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {tag.Name} Alreade Exists");
                return View(tag);
            }

            Tag existedTags = await _context.Tags.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedTags == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

           

            existedTags.Name = tag.Name.Trim();
            existedTags.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedTags.UpdatedBy = "System";

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

            Tag tag = await _context.Tags
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (tag == null)
            {
                return NotFound("Id Yanlisdir");
            }



            tag.IsDeleted = true;
            tag.DeletedBy = "";
            tag.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
