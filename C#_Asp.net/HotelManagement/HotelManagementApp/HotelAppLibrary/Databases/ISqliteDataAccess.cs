namespace HotelAppLibrary.Databases
{
    public interface ISqliteDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameter, string connectionStringName);
        void SaveData<T>(string sqlStatement, T parameter, string connectionStringName);
    }
}