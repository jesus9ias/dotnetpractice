using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ViewModels;
using dotnetpractice.Models;

namespace dotnetpractice.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(WebsiteDbContext dbContext) : base(dbContext) { }

        public IActionResult Index()
        {
            IQueryable<Category> catList = categories.GetCategories();
            HomeVM home = new HomeVM()
            {
                Categories = catList.Select(a => new CategoriesVM()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description
                }).ToList()
            };
            return View(home);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
