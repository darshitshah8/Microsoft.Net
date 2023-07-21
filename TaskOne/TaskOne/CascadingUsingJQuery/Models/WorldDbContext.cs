using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CascadingUsingJQuery.Models;

public partial class WorldDbContext : DbContext
{
    public WorldDbContext()
    {
    }

    public WorldDbContext(DbContextOptions<WorldDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<AllCascadingData> AllCascadingDatas { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WorldDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
