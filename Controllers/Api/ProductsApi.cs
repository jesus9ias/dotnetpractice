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
        [Route("Api/[controller]")]
        public JsonResult Index()
        {
            ProductsService products = new ProductsService();
            return Json(ResponseService.GetResponse("200", products.GetProducts()));
        }

        [HttpPut]
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
