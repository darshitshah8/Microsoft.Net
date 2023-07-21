using EntityFrameworkType.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ORMsLibrary.Models;
using System.Diagnostics;

namespace EntityFrameworkType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeSPController : ControllerBase
    {
        private readonly DataContext _context;

        public CakeSPController(DataContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<List<Cake>>> GetAll()
        {
            var result = await _context.Cakes.FromSqlRaw("sp_GetAllCakes").ToListAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Cake>>> GetCake(int id)
        {
            var result = await _context.Cakes.FromSqlRaw($"sp_GetCake {id}").ToListAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<List<Cake>> AddCake(Cake cake)
        {
            await _context.Database.ExecuteSqlAsync($"sp_AddCake @Name = {cake.Name}, @Price = {cake.Price}");
            return await _context.Cakes.ToListAsync();
        }
       

    }
}
