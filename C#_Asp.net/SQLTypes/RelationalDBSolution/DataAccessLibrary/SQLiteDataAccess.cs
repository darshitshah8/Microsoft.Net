using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SQLite;

namespace DataAccessLibrary
{
    public class SQLiteDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
   
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList(); // Query = Read
                return rows;
            }
        }
        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
             
                connection.Execute(sqlStatement, parameters);   // Execute = Write
            }
        }
    } 	

}
