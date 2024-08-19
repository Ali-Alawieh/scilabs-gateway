using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scilabs.Gateway.Application.Contract.Persistence;
using Scilabs.Gateway.Core.Entities;
using Scilabs.Gateway.Persistence.Repositories;

namespace Scilabs.Gateway.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection service, IConfiguration config)
    {
        service.AddDbContext<ScilabsDbContext>(option =>
        {
            option.UseNpgsql(config.GetConnectionString("ScilabsConnectionString")).ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryPossibleUnintendedUseOfEqualsWarning));
        });
        service.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        service.AddScoped<IEthouseRepository, EthouseRepository>();
        return service;
    }
}