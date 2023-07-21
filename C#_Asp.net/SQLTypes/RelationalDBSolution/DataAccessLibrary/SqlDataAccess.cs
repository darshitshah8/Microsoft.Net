﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class SqlDataAccess
    {
        public List<T> LoadData<T,U>(string sqlStatement,U parameters,string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement,parameters).ToList(); // Query = Read
                return rows;
            }
        }
        public void SaveData<T>(string sqlStatement , T parameters,string connectionString)
        {
            using(IDbConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Execute(sqlStatement, parameters);   // Execute = Write
            }
        }
     }
}
