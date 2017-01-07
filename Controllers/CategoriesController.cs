using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;

namespace dotnetpractice.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            CategoriesService categories = new CategoriesService();
            return View(categories.GetCategories());
        }

        [Route("Categories/{Slug}")]
        public IActionResult Details(string Slug)
        {
            CategoriesService categories = new CategoriesService();
            ProductsService products = new ProductsService();
            ViewBag.Category = categories.GetCategory(Slug);
            ViewBag.Products = products.GetProducts();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
