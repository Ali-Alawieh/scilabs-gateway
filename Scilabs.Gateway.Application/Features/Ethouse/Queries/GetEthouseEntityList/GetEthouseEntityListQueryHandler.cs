using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Scilabs.Gateway.Application.Contract.Persistence;

namespace Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseEntityList;

public class GetEthouseEntityListQueryHandler(
    IEthouseRepository repository,
    IMapper mapper,
    ILogger<GetEthouseEntityListQueryHandler> logger) : IRequestHandler<GetEthouseEntityListQuery, List<EntityVm>>
{
    public async Task<List<EntityVm>> Handle(GetEthouseEntityListQuery request, CancellationToken cancellationToken)
    {
        var result = await repository.ListEntity();
        foreach (var ethouse in result)
        {
            logger.LogInformation($"{ethouse.EntityId}");
        }

        logger.LogInformation($"Repository returns  ${result.Count} Items");
        var @entities = mapper.Map<List<EntityVm>>(result.Distinct());
        
        foreach (var entityVm in @entities)
        {
            SetEntityName(entityVm);
        }

        return @entities.OrderBy(x => x.EntityId).ToList();
    }

    private void SetEntityName(EntityVm vm)
    {
        if (!string.IsNullOrWhiteSpace(vm.EntityId))
        {
          var split =  vm.EntityId?.Split(":");
          vm.Name = $"House {split?[^1]}";
          logger.LogInformation($"SetEntityName: House {split?[^1]}"); 

        }
    }
    
}



