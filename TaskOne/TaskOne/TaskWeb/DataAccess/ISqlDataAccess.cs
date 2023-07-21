namespace TaskWeb.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storeProcedure, U parameter, string connectionStringName);
        Task SaveData<T>(string storeProcedure, T parameter, string connectionStringName);
    }
}