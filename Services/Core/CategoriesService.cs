using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models;
using dotnetpractice.Models.ViewModels.Categories;

namespace dotnetpractice.Services.Core
{
    public class CategoriesService
    {
        private WebsiteDbContext dbContext { get; set; }

        public CategoriesService(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CategoriesVM GetCategory(int Id)
        {
            Category catDb = dbContext.Categories.First(b => b.Id == Id);
            return new CategoriesVM()
            {
                Id = catDb.Id,
                Name = catDb.Name,
                Description = catDb.Description
            };
        }

        public List<CategoriesVM> GetCategories()
        {
            var catsDb = dbContext.Categories.OrderByDescending(a => a.Id).Take(10);
            return catsDb.Select(a => new CategoriesVM()
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description
            }).ToList();
        }
    }
}
