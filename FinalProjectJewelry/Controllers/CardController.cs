using FinalProjectJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = null;
            if (basket != null)
            {

             products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                return View(products);
            }
           return RedirectToAction("index", "home");
        }
    }
}
