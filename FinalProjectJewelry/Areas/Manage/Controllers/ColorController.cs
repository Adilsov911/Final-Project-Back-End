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
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ColorController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Colors.Where(b => b.IsDeleted == false).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Colors = _context.Colors.Where(c => c.IsDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Color color)
        {
            ViewBag.Colors = await _context.Colors
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(color);
            }

            if (await _context.Colors.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == color.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {color.Name} Alreade Exists");
                return View(color);
            }



            color.Name = color.Name.Trim();
            color.IsDeleted = false;
            color.DeletedAt = DateTime.UtcNow.AddHours(4);
            color.CreatedBy = "System";

            await _context.Colors.AddAsync(color);
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

            Color color = await _context.Colors.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (color == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Colors = await _context.Colors
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(color);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Color color)
        {
            ViewBag.Colors = await _context.Colors
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(color);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (color.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Colors.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == color.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {color.Name} Alreade Exists");
                return View(color);
            }

            Color existedColors = await _context.Colors.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedColors == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }



            existedColors.Name = color.Name.Trim();
            existedColors.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedColors.UpdatedBy = "System";

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

            Color color = await _context.Colors
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (color == null)
            {
                return NotFound("Id Yanlisdir");
            }



            color.IsDeleted = true;
            color.DeletedBy = "";
            color.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
