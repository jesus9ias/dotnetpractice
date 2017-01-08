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
            ProductsService products = new ProductsService();
            return View(products.GetProducts());
        }

        [Route("Products/{Id:int}")]
        public IActionResult Details(int Id)
        {
            ProductsService products = new ProductsService();
            return View(products.GetProduct(Id));
        }

        [Route("Products/{Id:int}/Edit")]
        public IActionResult Edit(int Id)
        {
          CategoriesService categories = new CategoriesService();
          return View(categories.GetCategories());
        }

        public IActionResult New()
        {
          CategoriesService categories = new CategoriesService();
          return View(categories.GetCategories());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
