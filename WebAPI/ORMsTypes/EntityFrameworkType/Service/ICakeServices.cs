using ORMsLibrary.Models;

namespace EntityFrameworkType.Service
{
    public interface ICakeServices
    {
        Task<List<Cake>> GetAllCakes();
        Task<Cake?> GetCake(int id);
        Task<List<Cake>> AddCake(Cake cake);
        Task<List<Cake>?> UpdateCake(int id, Cake request);
        Task<List<Cake>?> DeleteCake(int id);
    }
}