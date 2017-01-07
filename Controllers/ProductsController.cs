using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;

namespace dotnetpractice.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ProductsServices products = new ProductsServices();
            return View(products.GetProducts());
        }

        [Route("Products/{Id}")]
        public IActionResult Details(int Id)
        {
            ProductsServices products = new ProductsServices();
            return View(products.GetProduct(Id));
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
