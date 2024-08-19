using Microsoft.EntityFrameworkCore;
using Scilabs.Gateway.Application.Contract.Persistence;

namespace Scilabs.Gateway.Persistence.Repositories;

public class BaseRepository<T>(ScilabsDbContext dbContext) : IAsyncRepository<T> where T : class
{
    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await dbContext.Set<T>().ToListAsync();
    }
}