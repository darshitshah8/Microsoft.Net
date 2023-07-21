using HomeworkEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace HomeworkEF.DataAccess
{
    public class ContactContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employer> CompanyNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            options.UseSqlServer(config.GetConnectionString("Default"));
        }

    }
}
