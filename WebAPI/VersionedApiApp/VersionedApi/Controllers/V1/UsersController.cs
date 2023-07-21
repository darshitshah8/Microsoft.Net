using Microsoft.AspNetCore.Mvc;

namespace VersionedApi.Controllers.V1
{

    [Route("api/v1/[controller]")]
    [ApiController]
    [ApiVersion("1.0",Deprecated = true)]
    public class UsersController : ControllerBase
    {
        // GET: api/v2/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "version 1 value1", "version 1 value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
