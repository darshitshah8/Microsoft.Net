using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VersionedApi.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //[HttpGet]
        //[MapToApiVersion("2.0")]
        //public IEnumerable<string> GetV2()
        //{
        //    return new string[] { "version 2 value 1", "version 2 value2" };
        //}
    }
}
