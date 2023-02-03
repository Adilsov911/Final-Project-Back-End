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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders.Where(b => b.IsDeleted == false).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Slider = _context.Sliders.Where(c => c.IsDeleted == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            ViewBag.Sliders = await _context.Sliders
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(slider);
            }

           

            if (slider.SliderMainFile != null)
            {

                if (!slider.SliderMainFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                slider.Image = slider.SliderMainFile.SaveImg(_env.WebRootPath, "assest/img/slider");
            }
            if (slider.SliderTitleFile != null)
            {

                if (!slider.SliderTitleFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                slider.TitleImg = slider.SliderTitleFile.SaveImg(_env.WebRootPath, "assest/img/slider/inslideimg");
            }

            slider.IsDeleted = false;
            slider.DeletedAt = DateTime.UtcNow.AddHours(4);
            slider.CreatedBy = "System";
            slider.Right = slider.Right;
            await _context.Sliders.AddAsync(slider);
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

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (slider == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Slider = await _context.Sliders
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            ViewBag.Slider = await _context.Sliders
               .Where(c => c.IsDeleted == false)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(slider);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (slider.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

          

            Slider existedSlider = await _context.Sliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedSlider == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            if (slider.SliderMainFile != null)
            {
                if (!slider.SliderMainFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!slider.SliderMainFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assest/img/slider", existedSlider.Image);
                existedSlider.Image = slider.SliderMainFile.SaveImg(_env.WebRootPath, "assest/img/slider");


            }
            if (slider.SliderTitleFile != null)
            {
                if (!slider.SliderTitleFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!slider.SliderTitleFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 5mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assest/img/slider/inslideimg", existedSlider.TitleImg);
                existedSlider.TitleImg = slider.SliderTitleFile.SaveImg(_env.WebRootPath, "assest/img/slider/inslideimg");


            }

            existedSlider.Right = slider.Right;
            existedSlider.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedSlider.UpdatedBy = "System";

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

            Slider slider = await _context.Sliders
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (slider == null)
            {
                return NotFound("Id Yanlisdir");
            }



            slider.IsDeleted = true;
            slider.DeletedBy = "Adil";
            slider.DeletedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
