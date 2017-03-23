using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels.Products;
using dotnetpractice.Models.ViewModels.Categories;
using dotnetpractice.Models;

namespace dotnetpractice.Services.Core
{
    public class ProductsService
    {
        private WebsiteDbContext dbContext { get; set; }

        public ProductsService(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ProductsVM GetProduct(int Id)
        {
            var productDb = dbContext.Products.First(b => b.Id == Id);

            return new ProductsVM
            {
                Id = productDb.Id,
                Name = productDb.Name,
                Description = productDb.Description,
                Price = productDb.Price,
                Inventory = productDb.Inventory,
                Category = productDb.Category
            };
        }

        public List<ProductsVM> GetProducts()
        {
            var productsDb = dbContext.Products.OrderByDescending(a => a.Id).Take(10);
            return productsDb.Select(a => new ProductsVM()
            {
              Id = a.Id,
              Name = a.Name,
              Description = a.Description,
              Price = a.Price,
              Inventory = a.Inventory,
              Image = a.Image,
              Category = a.Category
            }).ToList();
        }
    }
}
