using Dapper;
using Microsoft.AspNetCore.Mvc;
using ORMsLibrary.Models;
using System.Data.SqlClient;

namespace ORMs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChocolateController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ChocolateController(IConfiguration config)
        {
            _config = config;
        }
        private static async Task<IEnumerable<Chocolate>> GetChocolates(SqlConnection connection)
        {
            return await connection.QueryAsync<Chocolate>("select * from chocolates");
        }
        [HttpGet]
        public async Task<ActionResult<List<Chocolate>>> GetAllChocolates()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("ChocolateConnectionString"));
            IEnumerable<Chocolate> chocolate = await GetChocolates(connection);
            return Ok(chocolate);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Chocolate>> GetChocolate(int id)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("ChocolateConnectionString"));
            var chocolate = await connection.QueryAsync<Chocolate>("select * from chocolates where id = @Id", new { Id = id });
            return Ok(chocolate);
        }
        [HttpPost]
        public async Task<ActionResult<List<Chocolate>>> AddChocolates(Chocolate chocolate)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("ChocolateConnectionString"));
            await connection.ExecuteAsync("insert into chocolates (name , price) values (@Name , @Price)",chocolate);
            return Ok(await GetChocolates(connection));
        }
        [HttpPut]
        public async Task<ActionResult<List<Chocolate>>> UpdateChocolate(Chocolate chocolate)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("ChocolateConnectionString"));
            await connection.ExecuteAsync("update chocolates set name = @Name , price = @Price where id = @Id", chocolate);
            return Ok(await GetChocolates(connection));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Chocolate>>> DaleteChocolate(int id)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("ChocolateConnectionString"));
            await connection.ExecuteAsync("delete from chocolates where id = @Id", new { Id = id });
            return Ok(await GetChocolates(connection));
        }
    }
}
