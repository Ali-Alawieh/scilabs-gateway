using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Scilabs.Gateway.Application.Contract.Persistence;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Persistence.Repositories;

public class EthouseRepository(ScilabsDbContext dbContext,IConfiguration configuration) : BaseRepository<Ethouse>(dbContext), IEthouseRepository
{
    private readonly ScilabsDbContext _dbContext = dbContext;

    public async Task<IReadOnlyList<Ethouse>> ListAllLimitedAsync()
    {
        return await _dbContext.Set<Ethouse>()
            .OrderByDescending(x => x.TimeIndex)
            .Take(500)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Ethouse>> ListEntity()
    {
        return await _dbContext.Set<Ethouse>()
            .OrderByDescending(x => x.TimeIndex)
            .Take(10)
            .ToListAsync();
    }


    public async Task<IReadOnlyList<BucketDiPHouse>> ListAllById(string entityId)
    {
        var query = @"
        SELECT DISTINCT ON (timeindex)
            time_bucket('30 sec', time_index) AS timeindex,
            AVG(batteryvoltage) AS batteryvoltage,
            AVG(batterycurrent) AS batterycurrent,
            AVG(batterypower) AS batterypower,
            AVG(solarvoltage) AS solarvoltage,
            AVG(solarpower) AS solarpower,
            AVG(loadvoltage) AS loadvoltage,
            AVG(solarcurrent) AS solarcurrent,
            AVG(loadcurrent) AS loadcurrent,
            AVG(loadpower) AS loadpower,
            AVG(exchangevoltage) AS exchangevoltage,
            AVG(exchangecurrent) AS exchangecurrent,
            AVG(exchangepower) AS exchangepower,
            AVG(currentexchangemode) AS currentexchangemode,
            entity_id AS entityid
        FROM mtmodels.etdevice
        WHERE entity_id = {0}
        GROUP BY timeindex, entity_id
        ORDER BY timeindex DESC
        LIMIT 10";

        var result = await _dbContext.Set<BucketDiPHouse>()
            .FromSqlRaw(query,new NpgsqlParameter("entityId", entityId))
            .ToListAsync();

        return result;
    }
}