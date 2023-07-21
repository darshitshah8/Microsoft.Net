using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniprojectApi.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniprojectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger _logger;

        public PersonController(ILogger<PersonModel> logger)
        {
            _logger = logger;
        }
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
            _logger.LogInformation("The persron was logged as {Personn}",data);
        }

    }
}
