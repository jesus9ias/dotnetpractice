using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetpractice.Services.Core;
using dotnetpractice.Models;

namespace dotnetpractice.Controllers
{
    public class ProductsController : Controller
    {
        private WebsiteDbContext dbContext;
        public ProductsController(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var productsDb = dbContext.Products.OrderByDescending(a => a.Id).Take(10);
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
