using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Application.Contract.Persistence;

public interface IEthouseRepository : IAsyncRepository<Ethouse>
{
    Task<IReadOnlyList<Ethouse>> ListAllLimitedAsync();

    Task<IReadOnlyList<Ethouse>> ListEntity();

    Task<IReadOnlyList<BucketDiPHouse>> ListAllById(string entityId,int intervalInMinutes);

  
}