using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels;

namespace dotnetpractice.Services
{
    public class ProductsService
    {
        private WebsiteDbContext dbContext { get; set; }

        public ProductsService(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
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

        public Product GetProduct(int Id)
        {
            return dbContext.Products.First(b => b.Id == Id);
        }        
    }
}
