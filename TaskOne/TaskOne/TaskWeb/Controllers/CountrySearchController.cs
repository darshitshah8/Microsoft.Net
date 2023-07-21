using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TaskWeb.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountrySearchController : ControllerBase
    {
        private readonly DataContext _context;
        public CountrySearchController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<SearchController>
        [HttpGet]
        public ActionResult<IEnumerable<CountryModel>> GetAllCountry()
        {
            return Ok(_context.Country.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<CountryModel> GetAllCountryById(int id)
        {
            var country = _context.Country.FirstOrDefault(c => c.CountryId == id);
            if (country == null)
            {
                return NotFound(); // Return a 404 Not Found response if the country is not found
            }
            return Ok(country);
        }



    }
}
