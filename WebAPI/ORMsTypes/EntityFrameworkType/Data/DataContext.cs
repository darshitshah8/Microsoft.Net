using Microsoft.EntityFrameworkCore;
using ORMsLibrary.Models;

namespace EntityFrameworkType.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        #region Second Option for add Configuration
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("CakeConnectionString");
        //} 
        #endregion

        public DbSet<Cake> Cakes { get; set; }
    }
}
