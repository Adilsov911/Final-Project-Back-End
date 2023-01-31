using FinalProjectJewelry.Models;
using FinalProjectJewelry.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Interfaces
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingAsync();
        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<IEnumerable<BasketVM>> GetBaskteAsync();
    }
}
