using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;
using dotnetpractice.Models.ViewModels.Products;

namespace dotnetpractice.Controllers.Api
{

    public class ProductsApi : Controller
    {
        private WebsiteDbContext dbContext;
        public ProductsApi(WebsiteDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Route("Api/[controller]")]
        public JsonResult Index()
        {
            ProductsService products = new ProductsService(dbContext);
            return Json(ResponseService.GetResponse("200", products.GetProducts()));
        }

        [Route("Api/[controller]/{Id:int}")]
        public JsonResult Get(int Id)
        {
            ProductsService products = new ProductsService(dbContext);
            return Json(ResponseService.GetResponse("200", products.GetProduct(Id)));
        }

        [HttpPost]
        [Route("Api/[controller]/{Id:int}")]
        public JsonResult Update(ProductsVM model)
        {
            return Json(ResponseService.GetResponse("200", model));
        }

        [HttpPost]
        [Route("Api/[controller]")]
        public JsonResult Save(ProductsVM model)
        {
            return Json(ResponseService.GetResponse("200", model));
        }
    }
}
