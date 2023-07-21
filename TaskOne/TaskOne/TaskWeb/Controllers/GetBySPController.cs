using Library.Models;
using Microsoft.AspNetCore.Mvc;
using TaskWeb.Data;
using TaskWeb.DataAccess;
using TaskWeb.Models;


namespace TaskWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class GetBySPController : ControllerBase
    {
        private readonly ICascadingData _data;        

        public GetBySPController(ICascadingData data)
        {
            _data = data;            
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<AllDataModel>> Get()
        {
            var output = await _data.GetAllData();
            return Ok(output);

        }

        [HttpGet("{id}, GetAllDataByCountryId")]
        public async Task<ActionResult<AllDataModel>> Get(int id) 
        => Ok((List<AllDataModel>?)await _data.GetAllDataById(id));

        [HttpGet("GetCountries")]
        public async Task<ActionResult<CountryModel>> GetAllCountry() 
        => Ok((List<CountryModel>?)await _data.GetAllCountry());

        [HttpGet("{id}, GetCountry")]
        public async Task<ActionResult<CountryModel>> GetAllCountryByCountryId(int id) 
        => Ok((List<CountryModel>?)await _data.GetCountryByCountryId(id));

        [HttpGet("GetStates")]
        public async Task<ActionResult<StateModel>> GetAllState() 
        => Ok((List<StateModel>?)await _data.GetAllState());

        [HttpGet("{id}, GetState")]
        public async Task<ActionResult<StateModel>> GetAllStateByCountryId(int id) 
        => Ok((List<StateModel>?)await _data.GetStateByCountryId(id));

        [HttpGet("GetAllCities")]
        public async Task<ActionResult<CityModel>> GetAllCity() 
        => Ok((List<CityModel>?)await _data.GetAllCity());

        [HttpGet("{id}, GetAllCityByStateId")]
        public async Task<ActionResult<CityModel>> GetAllCityByStateId(int id)
        => Ok((List<CityModel>?)await _data.GetCityByStateId(id));

    }
}
