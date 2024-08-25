using System.Web;
using MediatR;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseById;

public class GetEthouseByIdQuery(String entityId) : IRequest<List<BucketDiPHouse>>
{
    public string EntityId { get; set; } = HttpUtility.UrlDecode(entityId);
}