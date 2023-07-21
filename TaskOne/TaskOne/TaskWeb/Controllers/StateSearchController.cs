using Library.Models;
using Microsoft.AspNetCore.Mvc;
using TaskWeb.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateSearchController : ControllerBase
    {
        private readonly DataContext _context;
        public StateSearchController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<StateModel>> GetAllState()
        {
            return Ok(_context.State.ToList());
        }

        // GET api/<StateSearchController>/5
        [HttpGet("{id}")]
        public ActionResult<StateModel> GetStateByCountryId(int id)
        {
            var state = _context.State.Where(c => c.CountryId == id);
            if (state == null)
            {
                return NotFound(); // Return a 404 Not Found response if the country is not found
            }

            return Ok(state);
        }


    }
}
