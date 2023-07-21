using Library.Models;
using TaskWeb.Models;

namespace TaskWeb.DataAccess
{
    public interface ICascadingData
    {
        Task<List<AllDataModel>> GetAllData();
        Task<List<AllDataModel>> GetAllDataById(int id);       
        Task<List<CountryModel>> GetAllCountry();
        Task<List<CountryModel>> GetCountryByCountryId(int id);
        Task<List<StateModel>> GetAllState();
        Task<List<StateModel>> GetStateByCountryId(int id);
        Task<List<CityModel>> GetAllCity();
        Task<List<CityModel>> GetCityByStateId(int id);
    }
}