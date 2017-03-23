using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetpractice.Services.Core;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels.Products;

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

            List<ProductsVM> products = productsDb.Select(a => new ProductsVM()
            {
              Id = a.Id,
              Name = a.Name,
              Description = a.Description,
              Price = a.Price,
              Inventory = a.Inventory,
              Image = a.Image,
              Category = a.Category
            }).ToList();

            //  List<Product> products = new List<Product>(productsDb.ToList());
            //  ProductsService products = new ProductsService();
            return View(products);
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
