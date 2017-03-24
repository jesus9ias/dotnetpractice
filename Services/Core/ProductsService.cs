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

        public Product GetProduct(int Id)
        {
            return dbContext.Products.First(b => b.Id == Id);
        }

        public IQueryable<Product> GetProducts(int CategoryId = 0)
        {
            IQueryable<Product> productsDb = null;
            if (CategoryId > 0)
            {
                productsDb = dbContext.Products.Where(b => b.Category == CategoryId).OrderByDescending(a => a.Id);
            }
            else
            {
                productsDb = dbContext.Products.OrderByDescending(a => a.Id);
            }
            return productsDb;
        }
    }
}
