using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dotnetpractice.Controllers.Api
{
    public class person
    {
        public string name { get; set; }
    }

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            //return Json(new JavaScriptSerializer().Serialize( new {ok = true, hi = false }));
            person p = new person();
            p.name = "pepe";
            return JsonConvert.SerializeObject(new {name = "juan", lastname = "pancho" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
