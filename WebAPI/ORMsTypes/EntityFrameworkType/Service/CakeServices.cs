using EntityFrameworkType.Data;
using Microsoft.EntityFrameworkCore;
using ORMsLibrary.Models;
using System.Runtime.InteropServices;

namespace EntityFrameworkType.Service
{
    public class CakeServices : ICakeServices
    {
        private readonly DataContext _context;
        public CakeServices(DataContext context) => _context = context;

        #region Get
        public async Task<List<Cake>> GetAllCakes()
        {
            var cakes = await _context.Cakes.ToListAsync();
            return cakes;
        }
        #endregion

        #region Get {id}
        public async Task<Cake> GetCake(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            if (cake == null)
            {
                return null;
            }
            return cake;
        } 
        #endregion

        #region Post
        public async Task<List<Cake>> AddCake(Cake cake)
        {
            var cakes = _context.Cakes.Add(cake);
            await _context.SaveChangesAsync();
            return await _context.Cakes.ToListAsync();
        }
        #endregion

        #region Update
        public async Task<List<Cake>?> UpdateCake(int id, Cake request)
        {
            var cake = await _context.Cakes.FindAsync(id);
            if (cake == null)
                return null;
            cake.Name = request.Name;
            cake.Price = request.Price;

            await _context.SaveChangesAsync();

            return await _context.Cakes.ToListAsync();
        }
        #endregion

        #region Delete
        public async Task<List<Cake>?> DeleteCake(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            if (cake == null)
                return null;
            _context.Cakes.Remove(cake);
            await _context.SaveChangesAsync();
            return await _context.Cakes.ToListAsync();
        }
        #endregion
    }
}
