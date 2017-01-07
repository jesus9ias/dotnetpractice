using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;

namespace dotnetpractice.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            ProductsService products = new ProductsService();
            return View(products.GetProducts());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
