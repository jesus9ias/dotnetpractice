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
        private WebsiteDbContext dbContext;
        public ProductsController(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ProductsService products = new ProductsService(dbContext);
            return View(products.GetProducts());
        }

        [Route("Products/{Id:int}")]
        public IActionResult Details(int Id)
        {
            ProductsService products = new ProductsService(dbContext);
            return View(products.GetProduct(Id));
        }

        [Route("Products/{Id:int}/Edit")]
        public IActionResult Edit(int Id)
        {
            ProductsService products = new ProductsService(dbContext);
            return View(products.GetProduct(Id));
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
