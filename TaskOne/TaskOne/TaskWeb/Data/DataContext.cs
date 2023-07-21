using Library.Models;
using Microsoft.EntityFrameworkCore;
using TaskWeb.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace TaskWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<AllDataModel> GetallData { get; set; }
        public DbSet<CountryModel> Country { get; set; }
        public DbSet<StateModel> State { get; set; }
        public DbSet<CityModel> City { get; set; }        
    }
}
