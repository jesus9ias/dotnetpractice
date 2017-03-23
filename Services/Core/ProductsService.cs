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

        public ProductsVM GetProduct(int Id)
        {
            return new ProductsVM
            {
                Id = Id,
                Name = "Sharp TV",
                Description = "A big TV",
                Price = 300.21,
                Inventory = 11,
                Category = new CategoriesVM
                {
                  Slug = "electronics"
                }
            };
        }

        public List<ProductsVM> GetProducts()
        {
            return new List<ProductsVM>
            {
                new ProductsVM { Id = 1, Name = "Macboc Pro", Price = 2513.45 },
                new ProductsVM { Id = 2, Name = "Sharp TV", Price = 599.99 },
                new ProductsVM { Id = 3, Name = "Acer Aspire", Price = 435.19 },
                new ProductsVM { Id = 4, Name = "Pavilion", Price = 543.21 }
            };
        }
    }
}
