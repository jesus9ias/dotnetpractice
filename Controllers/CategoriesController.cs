using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels.Categories;
using dotnetpractice.Models.ViewModels.Products;

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
            CategoriesVM category = new CategoriesVM
            {
                Slug = "tvs",
                Name = "TV's",
                Description = "A big TV"
            };
            ViewBag.Category = category;
            ViewBag.Products = GetProducts();
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

        private static List<ProductsVM> GetProducts()
        {
            return new List<ProductsVM>
            {
                new ProductsVM { Id = 1, Name = "Macboc Pro", Price = 2513.45 },
                new ProductsVM { Id = 1, Name = "Sharp TV", Price = 599.99 },
                new ProductsVM { Id = 1, Name = "Acer Aspire", Price = 435.19 },
            };
        }
    }
}
