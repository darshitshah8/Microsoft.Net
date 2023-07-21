using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskWeb.Data;
using TaskWeb.Models;


namespace TaskWeb.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GetAllController : ControllerBase
{
    private readonly DataContext _context;

    // GET: api/AllCities
    public GetAllController(DataContext context)
    {
        _context = context;
    }
    //GET: api/<GetAllController>
    [HttpGet]
    public IEnumerable<AllDataModel> Get() 
        => (List<AllDataModel>?)(from p in _context.Country
            join sn in _context.State on p.CountryId equals sn.CountryId into stateJoin
            from sn in stateJoin.DefaultIfEmpty()
            join cn in _context.City on sn.StateId equals cn.StateId into cityJoin
            from cn in cityJoin.DefaultIfEmpty()
            select new AllDataModel
            {
                CountryId = p.CountryId,
                CountryName = p.CountryName,
                StateName = sn != null ? sn.StateName : null,
                CityName = cn != null ? cn.CityName : null
            }).ToList();

    //GET api/<GetAllController>/5
    [HttpGet("{id}")]
    public IEnumerable<AllDataModel> GetAllNames(int id)
    {
        var lists = (from p in _context.Country
                     join sn in _context.State on p.CountryId equals sn.CountryId into stateJoin
                     from sn in stateJoin.DefaultIfEmpty()
                     join cn in _context.City on sn.StateId equals cn.StateId into cityJoin
                     from cn in cityJoin.DefaultIfEmpty()
                     where p.CountryId == id
                     select new AllDataModel
                     {
                         CountryId = p.CountryId,
                         CountryName = p.CountryName,
                         StateName = sn != null ? sn.StateName : null,
                         CityName = cn != null ? cn.CityName : null
                     }).ToList();
        return lists;
    }
}
