using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Text;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;

namespace DataAccessLibrary
{
    public class MySqlDataAccess
    {   
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {

                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList(); // Query = Read
                return rows;
            }
        }
        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {

                connection.Execute(sqlStatement, parameters);   // Execute = Write
            }
        }
    }
}
