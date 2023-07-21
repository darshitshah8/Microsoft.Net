using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TodoLibrary.DataAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadData<T, U>(
                                 string storeProcedure,
                                 U parameter,
                                 string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(storeProcedure, parameter,
            commandType: CommandType.StoredProcedure);

        return rows.ToList();
    }
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
