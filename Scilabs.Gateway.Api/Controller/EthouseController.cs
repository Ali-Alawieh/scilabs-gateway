using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseById;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseEntityList;
using Scilabs.Gateway.Application.Features.Ethouse.Queries.GetEthouseList;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Api.Controller;

[ApiController]
[Route("api/House")]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
public class EthouseController : ControllerBase
{
    private readonly IMediator _mediator;

    public EthouseController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "Get the last 1000 entries of the database")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<EthouseVm>>> GetAll()
    {
        var dtos = await _mediator.Send(new GetEthouseQuery());
        return Ok(dtos);
    }

    [HttpGet("entities", Name = "Get a list of available entities")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<EntityVm>>> GetEntityList()
    {
        var dtos = await _mediator.Send(new GetEthouseEntityListQuery());
        return Ok(dtos);
    }

    [HttpGet("allById", Name = "Get a list of entity values by Id")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<BucketDiPHouse>>> GetEntityListById([FromQuery] String entityId)
    {
        var dtos = await _mediator.Send(new GetEthouseByIdQuery(entityId));
        return Ok(dtos);
    }
}