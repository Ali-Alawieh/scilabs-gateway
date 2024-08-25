using AutoMapper;
using MediatR;
using Scilabs.Gateway.Application.Contract.Persistence;
using Scilabs.Gateway.Application.Exceptions;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseById;

public class GetEthouseByIdQueryHandler(IEthouseRepository repository, IMapper mapper)
    : IRequestHandler<GetEthouseByIdQuery, List<BucketDiPHouse>>
{
    public async Task<List<BucketDiPHouse>> Handle(GetEthouseByIdQuery request, CancellationToken cancellationToken)
    {
        var houseDataList = await repository.ListAllById(request.EntityId);

        if (houseDataList.Count == 0)
        {
            throw new NotFoundException("Wrong EntityId? Id Not Found", request.EntityId);
        }

        var @result = mapper.Map<List<BucketDiPHouse>>(houseDataList);

        return @result;
    }
}