using CascadingUsingJQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace CascadingUsingJQuery.Controllers
{
    public class GetDataBySearchController : Controller
    {
        //private readonly WorldDbContext _context;
        //private readonly IConfiguration _config;

        //public GetDataBySearchController(WorldDbContext context,IConfiguration config)
        //{
        //    _context = context;
        //    _config = config;
        //}
        //public ActionResult GetAllBySearch(int id, string country, string state, string city)
        //{
        //    string connectionString = _config.GetConnectionString("Default");
        //    List<AllCascadingData> resultList = new List<AllCascadingData>();

        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("spWorldData_GetAllBySearch", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@ID", id);
        //        com.Parameters.AddWithValue("@CountryName", country);
        //        com.Parameters.AddWithValue("@StateName", state);
        //        com.Parameters.AddWithValue("@CityName", city);
        //        SqlDataReader rdr = com.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            resultList.Add(new AllCascadingData
        //            {
        //                Record = Convert.ToInt32(rdr["Record"]),
        //                CountryId = Convert.ToInt32(rdr["CountryId"]),
        //                CountryName = rdr["CountryName"].ToString(),
        //                StateName = rdr["StateName"].ToString(),
        //                CityName = rdr["CityName"].ToString(),
        //            });
        //        }
        //    }
        //    return Json(resultList);
        //}
        public IActionResult Index()
        {
            return View();
        }
    }
}

