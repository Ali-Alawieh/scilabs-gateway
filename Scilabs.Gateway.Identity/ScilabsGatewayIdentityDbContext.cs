using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Scilabs.Gateway.Identity.Models;

namespace Scilabs.Gateway.Identity;

public class ScilabsGatewayIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public ScilabsGatewayIdentityDbContext()
    {
    }


    public ScilabsGatewayIdentityDbContext(DbContextOptions<ScilabsGatewayIdentityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Set schema for Identity tables
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            if (entity.ClrType.Namespace == "Microsoft.AspNetCore.Identity")
            {
                entity.SetSchema("IdentitySchema");
            }
        }
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
    }
}