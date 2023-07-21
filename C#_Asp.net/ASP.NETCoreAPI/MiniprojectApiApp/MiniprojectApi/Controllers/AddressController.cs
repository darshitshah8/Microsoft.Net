using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniprojectApi.Model;

namespace MiniprojectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger _logger;

        public AddressController(ILogger<AddressModel> logger)
        {
            _logger = logger;
        }
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
            _logger.LogInformation("The persron was logged as {Address}", data);
        }
    }
}
