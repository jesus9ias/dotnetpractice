using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels.Products;

namespace dotnetpractice.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController(WebsiteDbContext dbContext) : base(dbContext) { }

        public IActionResult Index()
        {
            ProductsService products = new ProductsService(dbContext);
            IQueryable<Product> productList = products.GetProducts();
            return View(productList.Select(a => new ProductsVM()
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                Price = a.Price,
                Inventory = a.Inventory,
                Image = a.Image,
                Category = a.Category
            }).ToList());
        }

        [Route("Products/{Id:int}")]
        public IActionResult Details(int Id)
        {
            ProductsService products = new ProductsService(dbContext);
            Product product = products.GetProduct(Id);

            return View(new ProductsVM()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Inventory = product.Inventory,
                Category = product.Category
            });
        }

        [Route("Products/{Id:int}/Edit")]
        public IActionResult Edit(int Id)
        {
            ProductsService products = new ProductsService(dbContext);
            Product product = products.GetProduct(Id);

            return View(new ProductsVM()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Inventory = product.Inventory,
                Category = product.Category
            });
        }

        public IActionResult New()
        {
          return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
