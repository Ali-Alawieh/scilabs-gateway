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
            AVG(batterycapacity) AS batterycapacity,
            AVG(batterychargelevel) AS batterychargelevel,
            AVG(solarmodulevoltage) AS solarmodulevoltage,
            AVG(solarmodulepower) AS solarmodulepower,
            AVG(loadvoltage) AS loadvoltage,
            AVG(solarmodulecurrent) AS solarmodulecurrent,
            AVG(loadcurrent) AS loadcurrent,
            AVG(loadpower) AS loadpower,
            AVG(energyexchangevoltage) AS energyexchangevoltage,
            AVG(energyexchangecurrent) AS energyexchangecurrent,
            AVG(energyexchangepower) AS energyexchangepower,
            AVG(energyexchangemode) AS energyexchangemode,
            entity_id AS entityid
        FROM ""mthsbo_smartcity"".""etminiature-house""
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