using AutoMapper;
using MediatR;
using Scilabs.Gateway.Application.Contract.Persistence;

namespace Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;

public class GetEthouseQueryHandler(IEthouseRepository ethouseRepository, IMapper mapper)
    : IRequestHandler<GetEthouseQuery, List<EthouseVm>>
{
    public async Task<List<EthouseVm>> Handle(GetEthouseQuery request, CancellationToken cancellationToken)
    {
        var house = await ethouseRepository.ListAllLimitedAsync();
        return mapper.Map<List<EthouseVm>>(house);
    }
}