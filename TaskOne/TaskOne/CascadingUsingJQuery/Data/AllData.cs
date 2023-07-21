using CascadingUsingJQuery.Models;
using System.Data;
using System.Data.SqlClient;

namespace CascadingUsingJQuery.Data
{
    public class AllData : IData
    {
        private readonly IConfiguration _config;
        public AllData(IConfiguration config)
        {
            _config = config;
        }

        public List<AllCascadingData> ListAll()
        {
            string connectionString = _config.GetConnectionString("Default");
            List<AllCascadingData> ListAll = new List<AllCascadingData>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("spWorldData_GetAll", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ListAll.Add(new AllCascadingData
                    {
                        CountryId = Convert.ToInt32(rdr["CountryId"]),
                        CountryName = rdr["CountryName"].ToString(),
                        StateName = rdr["StateName"].ToString(),
                        CityName = rdr["CityName"].ToString(),
                    });
                }
                return ListAll;
            }
        }
        public List<AllCascadingData> ListById(int id)
        {
            string connectionString = _config.GetConnectionString("Default");
            List<AllCascadingData> ListOne = new List<AllCascadingData>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand("spWorldData_GetAllById", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("ID", id);
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    ListOne.Add(new AllCascadingData
                    {
                        Record = Convert.ToInt32(rdr["Record"]),
                        CountryId = Convert.ToInt32(rdr["CountryId"]),
                        CountryName = rdr["CountryName"].ToString(),
                        StateName = rdr["StateName"].ToString(),
                        CityName = rdr["CityName"].ToString(),
                    });
                }
                return ListOne;
            }
        }
    }
}
