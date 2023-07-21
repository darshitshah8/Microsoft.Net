using Library.Models;
using Microsoft.AspNetCore.Mvc;
using TaskWeb.Data;

namespace TaskWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitySearchController : ControllerBase
    {
        private readonly DataContext _context;

        // GET: api/AllCities
        public CitySearchController(DataContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CityModel>> GetAllCity()
        {
            return Ok(_context.City.ToList());
        }

        // GET api/<StateSearchController>/5
        [HttpGet("{id}")]
        public ActionResult<CityModel> GetAllCityByStateId(int id)
        {
            var City = _context.City.Where(c => c.StateId == id);
            if (City == null)
            {
                return NotFound(); 
            }
            return Ok(City);
        }


    }
}
