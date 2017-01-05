using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels.Categories;

namespace dotnetpractice.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View(GetCategories());
        }

        [Route("Categories/{Slug}")]
        public IActionResult Details(string Slug)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        private static List<CategoriesVM> GetCategories()
        {
            return new List<CategoriesVM>
            {
                new CategoriesVM { Slug = "pcs", Name = "PC's", Description = "The best PC's" },
                new CategoriesVM { Slug = "appliances", Name = "Home Appliances", Description = "For your Home" },
                new CategoriesVM { Slug = "games", Name = "Games", Description = "Best Entertaiment" }
            };
        }
    }
}
