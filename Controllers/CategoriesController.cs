using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;
using dotnetpractice.Models.ViewModels.Categories;
using dotnetpractice.Models.ViewModels.Products;
using dotnetpractice.Models;

namespace dotnetpractice.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(WebsiteDbContext dbContext) : base(dbContext) { }

        public IActionResult Index()
        {
            CategoriesService categories = new CategoriesService(dbContext);
            return View(categories.GetCategories());
        }

        [Route("Categories/{Id}")]
        public IActionResult Details(int Id)
        {
            CategoriesService categories = new CategoriesService(dbContext);
            ProductsService products = new ProductsService(dbContext);
            IQueryable<Product> productList = products.GetProducts(CategoryId: Id);
            CategoryProductsVM CatProducts = new CategoryProductsVM
            {
                Category = categories.GetCategory(Id),
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
