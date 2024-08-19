using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Scilabs.Gateway.Application.Contract.Persistence;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Persistence.Repositories;

public class EthouseRepository(ScilabsDbContext dbContext,IConfiguration configuration) : BaseRepository<Ethouse>(dbContext), IEthouseRepository
{
    public async Task<IReadOnlyList<Ethouse>> ListAllLimitedAsync()
    {
        return await dbContext.Set<Ethouse>()
            .OrderByDescending(x => x.TimeIndex)
            .Take(500)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Ethouse>> ListEntity()
    {
        return await dbContext.Set<Ethouse>()
            .OrderByDescending(x => x.TimeIndex)
            .Take(10)
            .ToListAsync();
    }


    public async Task<IReadOnlyList<BucketDiPHouse>> ListAllById(string entityId)
    {
        var query = @"
        SELECT DISTINCT ON (timeindex)
            time_bucket('30 min', time_index) AS timeindex,
            AVG(di_p_haus) AS di_p_haus,
            AVG(di_p_batt_soc) AS di_p_batt_soc,
            AVG(di_p_solar) AS di_p_solar,
            AVG(di_p_netz) AS di_p_netz,
            AVG(di_p_wp) AS di_p_wp,
            entity_id AS entityid
        FROM mtstwh.ethouse
        WHERE entity_id = {0}
        GROUP BY timeindex, entity_id
        ORDER BY timeindex DESC
        LIMIT 10";

        var result = await dbContext.Set<BucketDiPHouse>()
            .FromSqlRaw(query, new NpgsqlParameter("entityId", entityId))
            .ToListAsync();

        return result;
    }
}