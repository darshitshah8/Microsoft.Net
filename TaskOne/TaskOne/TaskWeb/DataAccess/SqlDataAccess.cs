using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TaskWeb.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        //reads rows from a text file into a table at a very high speed
        public async Task<List<T>> LoadData<T, U>(
                                     string storeProcedure,
                                     U parameter ,
                                     string connectionStringName)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);

            var rows = await connection.QueryAsync<T>(storeProcedure, parameter,
                commandType: CommandType.StoredProcedure);

            return rows.ToList();
        }
        // stores a collection for later use under a name.
        public async Task SaveData<T>(
            string storeProcedure,
            T parameter, string connectionStringName)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);

            using IDbConnection connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(storeProcedure, parameter,
                commandType: CommandType.StoredProcedure);
        }

    }
}
