using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace StockMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TimeController:ControllerBase
    {

        //http://localhost:5000/api/Time/2        
        [HttpGet("{id}")]
        public string GetProduct(long id, [FromServices] ILogger<TimeController> logger)
        {
            logger.LogDebug("GetProduct Action Invoked");
            return "Ali: " + DateTime.Now.ToString() + "   " + HttpContext.Request.Headers.ToString();

        }

        ////http://localhost:5000/api/Time/
        //[HttpGet]
        //public string GetTime()
        //{
        //    return "GetTime()";
        //}

        //[HttpPost]
        //public string SaveProduct([FromBody] Product product)
        //{
        //    return "Ali: " + DateTime.Now.ToString() + "   " + HttpContext.Request.Headers.ToString();
        //}

        public string SayHello()
        {
            return "Hello " + DateTime.Now.ToLongTimeString();
        }
    }
}

