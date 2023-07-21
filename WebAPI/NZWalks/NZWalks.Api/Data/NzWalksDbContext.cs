using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Models;

namespace NZWalks.Api.Data
{
    public class NzWalksDbContext : DbContext
    {
        public NzWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
