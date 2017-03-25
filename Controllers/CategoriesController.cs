using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels;

namespace dotnetpractice.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(WebsiteDbContext dbContext) : base(dbContext) { }

        public IActionResult Index()
        {
            IQueryable<Category> catList = categories.GetCategories();
            return View(catList.Select(a => new CategoriesVM()
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description
            }).ToList());
        }

        [Route("Categories/{Id}")]
        public IActionResult Details(int Id)
        {
            Category cat = categories.GetCategory(Id);
            IQueryable<Product> productList = products.GetProducts(CategoryId: Id);
            CategoryProductsVM CatProducts = new CategoryProductsVM
            {
                Category = new CategoriesVM()
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    Description = cat.Description
                },
                Products = productList.Select(a => new ProductsVM()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    Price = a.Price,
                    Inventory = a.Inventory,
                    Image = a.Image,
                    Category = a.Category
                }).ToList()
            };
            return View(CatProducts);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
