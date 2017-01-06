using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels.Products;

namespace dotnetpractice.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(GetProducts());
        }

        public IActionResult Error()
        {
            return View();
        }

        private static List<ProductsVM> GetProducts()
        {
            return new List<ProductsVM>
            {
                new ProductsVM { Id = 1, Name = "Macboc Pro", Price = 2513.45 },
                new ProductsVM { Id = 2, Name = "Sharp TV", Price = 599.99 },
                new ProductsVM { Id = 3, Name = "Acer Aspire", Price = 435.19 },
            };
        }
    }
}
