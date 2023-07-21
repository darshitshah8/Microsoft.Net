using EntityFrameworkType.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORMsLibrary.Models;

namespace EntityFrameworkType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private readonly ICakeServices _cake;
        public CakeController(ICakeServices cake) => _cake = cake;

        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Cake>>> GetAllCake()
        {
            return await _cake.GetAllCakes();
        } 
        #endregion

        #region Get {id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cake>> GetCake(int id)
        {

            var result = await _cake.GetCake(id);
            if (result is null)
                return NotFound("Cake not found");
            return await _cake.GetCake(id);
        } 
        #endregion

        #region Post
        [HttpPost]
        public async Task<ActionResult<List<Cake>>> AddCake(Cake cake)
        {
            var cakes = await _cake.AddCake(cake);
            return Ok(await GetAllCake());
        } 
        #endregion

        #region Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cake>> DeleteCake(int id)
        {
            var result = await _cake.DeleteCake(id);
            if (result is null)
                return NotFound("Cake not found");
            return Ok(result);
        } 
        #endregion

        #region Update
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Cake>>> UpdateCake(int id, Cake cake)
        {
            var result = await _cake.UpdateCake(id, cake);
            if (result is null)
                return NotFound("Cake not found");
            return Ok();
        } 
        #endregion
    }
}
