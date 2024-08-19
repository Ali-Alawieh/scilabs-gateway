using AutoMapper;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseEntityList;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Ethouse, EthouseVm>().ReverseMap();
        CreateMap<Ethouse, EntityVm>().ReverseMap();
        CreateMap<EthouseVm, BucketDiPHouse>().ReverseMap();
    }
}