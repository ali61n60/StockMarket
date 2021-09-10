using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private List<string> data = new List<string>() { "value1", "value2", "vlaue3" };
        // GET: api/<ToDoController>
        [HttpGet]
        public List<string> Get()
        {
            return data;
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if(id<0 || id > (data.Count()-1))
            {
                return "Out of bound id supplied";
            }
            return $"data for id({id}) is {data[id]} ";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public string Post([FromBody] Message message)
        {
            
            if (!String.IsNullOrEmpty(message.Value))
                return $"The value that was post is {message.Value}";
            return "null or empty parameter supplied";
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Message
    {
        public string Value { get; set; }
    }
}
