using Microsoft.EntityFrameworkCore;
using Scilabs.Gateway.Core.Common;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Persistence;

public class ScilabsDbContext : DbContext
{
    public ScilabsDbContext(DbContextOptions<ScilabsDbContext> options) : base(options)
    {
    }

    private DbSet<Ethouse> ethouse { get; set; }
    public DbSet<BucketDiPHouse> BucketDiPHouses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ethouse>().ToTable("etdevice", "mtmodels");
        
        modelBuilder.Entity<BucketDiPHouse>().HasNoKey();
        
    }
}