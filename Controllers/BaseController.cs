using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetpractice.Services;
using dotnetpractice.Models;

namespace dotnetpractice.Controllers
{
    public class BaseController : Controller
    {
        public WebsiteDbContext dbContext;

        public ProductsService products
        {
            get { return new ProductsService(dbContext); }
        }

        public CategoriesService categories
        {
            get { return new CategoriesService(dbContext); }
        }

        public BaseController(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


    }
}
