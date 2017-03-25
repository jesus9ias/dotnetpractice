using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels;

namespace dotnetpractice.Services
{
    public class CategoriesService
    {
        private WebsiteDbContext dbContext { get; set; }

        public CategoriesService(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }   

        public IQueryable<Category> GetCategories()
        {
            return dbContext.Categories.OrderByDescending(a => a.Id);
        }

        public Category GetCategory(int Id)
        {
            return dbContext.Categories.First(b => b.Id == Id);
        }
    }
}
