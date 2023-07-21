using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SayHelloController : ControllerBase
    {
        // GET: api/<SayHello>
        [HttpGet]
        public IEnumerable<string> Get(string FirstName = " " ,string LastName="")
        {
            string output = FirstName + " " + LastName;
            return new string[] { "Hello , " + output };
        }

        // GET api/<SayHello>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SayHello>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SayHello>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SayHello>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
