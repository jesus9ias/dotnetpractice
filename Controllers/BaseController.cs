using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetpractice.Services.Core;
using dotnetpractice.Models;

namespace dotnetpractice.Controllers
{
    public class BaseController : Controller
    {
        public WebsiteDbContext dbContext;

        public BaseController(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


    }
}
