using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GettingStartedApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/Users
    [HttpGet("GetAllUser")]
    public IEnumerable<string> Get()
    {
        List<string> output = new();
        for (int i = 0; i < Random.Shared.Next(2,10); i++)
        {
            output.Add($"Value #{i+1}");
        }
        return output;
    }



    // GET api/Users/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"value {id+1}";
    }



    //POST create a new record
    // POST api/Users
    // https://localhost:7002/api/Users (POST)
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }



    // PUT update a whole record ( or possibly Create)
    // PUT api/Users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
        // FN , LN , Email , PhoneNumber
    }


    // PATCH Update part of record
    // PATCH api/Users/5
    [HttpPatch("{id}")]
    public void patch(int id, [FromBody] string emailAddress)
    {

    }

    // DELETE deletes a record
    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
