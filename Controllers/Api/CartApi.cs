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
            //ResponseService Response = new ResponseService();
            ProductsService products = new ProductsService();
            return Json(ResponseService.GetResponse("200", products.GetProducts()));
        }

        [HttpPost]
        [Route("api/[controller]/BuyCartProducts")]
        public JsonResult BuyCartProducts()
        {
            return Json(new List<int>{1,2,8,3});
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
