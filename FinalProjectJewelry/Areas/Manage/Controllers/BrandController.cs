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
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Brands.Where(b => b.IsDeleted == false).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Brands = _context.Brands.Where(c => c.IsDeleted == false).ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            ViewBag.Brands = await _context.Brands
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(brand);
            }

            if (await _context.Brands.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == brand.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {brand.Name} Alreade Exists");
                return View(brand);
            }


            if (brand.BrandFile != null)
            {

                if (!brand.BrandFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                brand.Image = brand.BrandFile.SaveImg(_env.WebRootPath, "assest/img/brandsimg");
            }

            brand.Name = brand.Name.Trim();
            brand.IsDeleted = false;
            brand.DeletedAt = DateTime.UtcNow.AddHours(4);
            brand.CreatedBy = "System";

            await _context.Brands.AddAsync(brand);
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

            Brand brand = await _context.Brands.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (brand == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Brands = await _context.Brands
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(brand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Brand brand)
        {
            ViewBag.Brands = await _context.Brands
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(brand);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (brand.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Brands.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == brand.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {brand.Name} Alreade Exists");
                return View(brand);
            }

            Brand existedBrand = await _context.Brands.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedBrand == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            if (brand.BrandFile != null)
            {
                if (!brand.BrandFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!brand.BrandFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assest/img/brandsimg", existedBrand.Image);
                existedBrand.Image = brand.BrandFile.SaveImg(_env.WebRootPath, "assest/img/brandsimg");


            }

            existedBrand.Name = brand.Name.Trim();
            existedBrand.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedBrand.UpdatedBy = "System";

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

            Brand brand = await _context.Brands
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (brand == null)
            {
                return NotFound("Id Yanlisdir");
            }



            brand.IsDeleted = true;
            brand.DeletedBy = "";
            brand.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
