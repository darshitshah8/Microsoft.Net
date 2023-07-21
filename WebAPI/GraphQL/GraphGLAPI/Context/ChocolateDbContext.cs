using GraphGLAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphGLAPI.Context
{
    public class ChocolateDbContext : DbContext
    {
        public ChocolateDbContext(DbContextOptions<ChocolateDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Chocolate> Chocolates { get; set; }
    }
}
