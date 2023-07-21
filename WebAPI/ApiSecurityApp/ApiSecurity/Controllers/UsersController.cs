using ApiSecurity.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _config;

        public UsersController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Users5
        [HttpGet("{id}")]
        [Authorize(Policy = PolicyConstants.MustHaveEmployeeId)]
        [Authorize(Policy = PolicyConstants.MustBeTheOwner)]
        public string Get(int id)
        {
            return _config.GetConnectionString("Default");
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Users
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Users
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}





//IConfiguration is allow to talk with appsettings.json among others.