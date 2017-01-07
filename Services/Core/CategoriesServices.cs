using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels.Categories;

namespace dotnetpractice.Services.Core
{
    public class CategoriesServices
    {
        public CategoriesVM GetCategory(string Slug)
        {
            return new CategoriesVM
            {
                Slug = "tvs",
                Name = "TV's",
                Description = "A big TV"
            };
        }

        public List<CategoriesVM> GetCategories()
        {
            return new List<CategoriesVM>
            {
                new CategoriesVM { Slug = "pcs", Name = "PC's", Description = "The best PC's" },
                new CategoriesVM { Slug = "appliances", Name = "Home Appliances", Description = "For your Home" },
                new CategoriesVM { Slug = "games", Name = "Games", Description = "Best Entertaiment" },
                new CategoriesVM { Slug = "electronics", Name = "Electronics", Description = "Electronics" }
            };
        }
    }
}
