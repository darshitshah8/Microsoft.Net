using Library.Models;
using System.Diagnostics.Metrics;
using TaskWeb.Models;

namespace TaskWeb.DataAccess;

public class CascadingData : ICascadingData
{
    private readonly ISqlDataAccess _sql;

    public CascadingData(ISqlDataAccess sql)
    {
        _sql = sql;
    }
    public Task<List<AllDataModel>> GetAllData() 
    { 
          return _sql.LoadData<AllDataModel,dynamic>(
              "dbo.spWorldData_GetAll",
              new {},
              "Default");
    }
    public Task<List<AllDataModel>> GetAllDataById(int id)
    {
        return _sql.LoadData<AllDataModel, dynamic>(
              "dbo.spWorldData_GetAllById",
              new {  Id = id },
              "Default");
    }
    public Task<List<CountryModel>> GetAllCountry()
    {
        return _sql.LoadData<CountryModel, dynamic>(
              "dbo.spWorldData_GetAllCountry",
              new {},
              "Default");
    }
    public Task<List<CountryModel>> GetCountryByCountryId(int id)
    {
        return _sql.LoadData<CountryModel, dynamic>(
              "dbo.spWorldData_GetAllCountryByCountryId",
              new { Id = id },
              "Default");
    }
    public Task<List<StateModel>> GetAllState()
    {
        return _sql.LoadData<StateModel, dynamic>(
              "dbo.spWorldData_GetAllState",
              new {  },
              "Default");
    }
    public Task<List<StateModel>> GetStateByCountryId(int id)
    {
        return _sql.LoadData<StateModel, dynamic>(
              "dbo.spWorldData_GetAllStateByCountryId",
              new { Id = id },
              "Default");
    }
    public Task<List<CityModel>> GetAllCity()
    {
        return _sql.LoadData<CityModel, dynamic>(
              "dbo.spWorldData_GetAllCity",
              new {},
              "Default");
    }
    public Task<List<CityModel>> GetCityByStateId(int id)
    {
        return _sql.LoadData<CityModel, dynamic>(
              "dbo.spWorldData_GetAllCityByStateId",
              new { Id = id },
              "Default");
    }


}