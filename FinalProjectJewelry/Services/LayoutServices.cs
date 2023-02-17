using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Interfaces;
using FinalProjectJewelry.Models;
using FinalProjectJewelry.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Services
{
    public class LayoutServices : ILayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;

        }

        public async Task<IEnumerable<BasketVM>> GetBaskteAsync()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            foreach (BasketVM basketVM in basketVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id && p.IsDeleted == false);

                basketVM.Title = product.Title;
                basketVM.Image = product.MainImage;
                basketVM.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
            }

            return basketVMs;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.Include(p=>p.Products)
                .Where(c => c.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<Dictionary<string, string>> GetSettingAsync()
        {
            return await _context.Settings
                .ToDictionaryAsync(s => s.Key, s => s.Value);
        }
    }
}
