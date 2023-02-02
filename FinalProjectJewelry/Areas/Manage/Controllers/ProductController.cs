using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .Where(p => p.IsDeleted == false)
                .ToListAsync();

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Brands = await _context.Brands.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(c => c.IsDeleted == false).ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Brands = await _context.Brands.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            if (!await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Id == product.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Secilen Kategoriya Yanlisdir");
                return View(product);
            }

            if (product.BrandId == null)
            {
                ModelState.AddModelError("BrandId", "Secilen Brand Yanlisdir");
                return View(product);
            }

            if (!await _context.Brands.AnyAsync(c => c.IsDeleted == false && c.Id == product.BrandId))
            {
                ModelState.AddModelError("BrandId", "Secilen Brand Yanlisdir");
                return View(product);
            }

            List<ProductTag> productTags = new List<ProductTag>();

            foreach (int tagId in product.TagIds)
            {
                if (product.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "Bir Tagdan Bir Ddefe Secilmelidir");
                    return View(product);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductTag productTag = new ProductTag
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                productTags.Add(productTag);
            }
            List<ProductColor> productColors = new List<ProductColor>();

            foreach (int colorId in product.ColorIds)
            {
                if (product.ColorIds.Where(t => t == colorId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "Bir Tagdan Bir Ddefe Secilmelidir");
                    return View(product);
                }

                if (!await _context.Colors.AnyAsync(c => c.IsDeleted == false && c.Id == colorId))
                {
                    ModelState.AddModelError("ColorIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductColor productColor = new ProductColor
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    ColorId = colorId
                };

                productColors.Add(productColor);
            }
            List<ProductSize> productSizes = new List<ProductSize>();

            foreach (int sizeId in product.ColorIds)
            {
                if (product.SizeIds.Where(t => t == sizeId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "Bir Tagdan Bir Ddefe Secilmelidir");
                    return View(product);
                }

                if (!await _context.Sizes.AnyAsync(c => c.IsDeleted == false && c.Id == sizeId))
                {
                    ModelState.AddModelError("ColorIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductSize productSize = new ProductSize
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    SizeId = sizeId
                };

                productSizes.Add(productSize);
            }
            product.ProductTags = productTags;
            product.ProductSizes = productSizes;
            product.ProductColors = productColors;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            product.TagIds = await _context.ProductTags.Where(pt => pt.ProductId == id).Select(x => x.TagId).ToListAsync();

            ViewBag.Brands = await _context.Brands.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(c => c.IsDeleted == false).ToListAsync();

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Product product)
        {
            ViewBag.Brands = await _context.Brands.Where(b => b.IsDeleted == false).ToListAsync();
            ViewBag.Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Colors = await _context.Colors.Where(c => c.IsDeleted == false).ToListAsync();
            ViewBag.Sizes = await _context.Sizes.Where(c => c.IsDeleted == false).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(product);
            }

            Product existedProduct = await _context.Products.Include(c => c.ProductTags).Include(c=>c.ProductSizes).Include(p=>p.ProductColors).FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            _context.ProductTags.RemoveRange(existedProduct.ProductTags);
            _context.ProductColors.RemoveRange(existedProduct.ProductColors);
            _context.ProductSizes.RemoveRange(existedProduct.ProductSizes);

            List<ProductSize> productSizes = new List<ProductSize>();

            List<ProductTag> productTags = new List<ProductTag>();
            List<ProductColor> productColors = new List<ProductColor>();
           

            foreach (int tagId in product.TagIds)
            {
                if (product.TagIds.Where(t => t == tagId).Count() > 1)
                {
                    ModelState.AddModelError("TagIds", "Bir Tagdan Bir Ddefe Secilmelidir");
                    return View(product);
                }

                if (!await _context.Tags.AnyAsync(c => c.IsDeleted == false && c.Id == tagId))
                {
                    ModelState.AddModelError("TagIds", "Secilen Tag  Yanlisdir");
                    return View(product);
                }

                ProductTag productTag = new ProductTag
                {
                    CreatedAt = DateTime.UtcNow.AddHours(+4),
                    CreatedBy = "System",
                    IsDeleted = false,
                    TagId = tagId
                };

                productTags.Add(productTag);
            } 
            existedProduct.ProductTags = productTags;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
