using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Services.Core;

namespace dotnetpractice.Controllers.Api
{

    public class CartApi : Controller
    {
        [Route("api/[controller]/GetCartProducts")]
        public JsonResult GetCartProducts()
        {
            ProductsService products = new ProductsService();
            return Json(ResponseService.GetResponse("200", products.GetProducts()));
        }

        [HttpPost]
        [Route("api/[controller]/BuyCartProducts")]
        public JsonResult BuyCartProducts()
        {
            return Json(new List<int>{1,2,8,3});
        }
    }
}
