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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Settings.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Settings = _context.Settings.ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Setting setting)
        {
            ViewBag.Settings = await _context.Settings
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(setting);
            }

            if (await _context.Settings.AnyAsync(c =>  c.Key.ToLower() == setting.Key.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {setting.Key} Alreade Exists");
                return View(setting);
            }
            if (await _context.Settings.AnyAsync(c => c.Value.ToLower() == setting.Value.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Value = {setting.Value} Alreade Exists");
                return View(setting);
            }


            

            setting.Key = setting.Key.Trim();
            setting.Value = setting.Value.Trim();
            await _context.Settings.AddAsync(setting);
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

            Setting setting = await _context.Settings.FirstOrDefaultAsync(c => c.Id == id);

            if (setting == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Settings = await _context.Settings
                .ToListAsync();

            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Setting setting)
        {
            ViewBag.Settings = await _context.Settings
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(setting);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (setting.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Settings.AnyAsync(c => c.Key.ToLower() == setting.Key.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Key", $"This Key = {setting.Key} Alreade Exists");
                return View(setting);
            }
            if (await _context.Settings.AnyAsync(c => c.Value.ToLower() == setting.Value.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Key", $"This Value = {setting.Value} Alreade Exists");
                return View(setting);
            }

            Setting existedSettings = await _context.Settings.FirstOrDefaultAsync(c => c.Id == id);

            if (existedSettings == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            

            existedSettings.Key = setting.Key.Trim();
            existedSettings.Value = setting.Value.Trim();

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
