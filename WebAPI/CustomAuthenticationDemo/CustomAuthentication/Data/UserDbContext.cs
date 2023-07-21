using CustomAuthentication.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthentication.Data
{
    public class UserDbContext : DbContext
    {
            public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
            {

            }

            public DbSet<UserModel> User { get; set; }
            public DbSet<UserRolesModel> UserRoles { get; set; }
        }
}