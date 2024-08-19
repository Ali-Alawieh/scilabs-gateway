using Microsoft.AspNetCore.Mvc;
using Scilabs.Gateway.Core.Entities;

namespace Scilabs.Gateway.Api.Controller;
[ApiController]
[Route("/")]
public class BaseController : ControllerBase
{
    
    [HttpGet("health", Name = "Health")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public Task<ActionResult<Health>> GetHealth()
    {
        var healthStatus = new Health
        {
            Status = "Healthy",
            Timestamp = DateTime.UtcNow
        };
        
        return Task.FromResult<ActionResult<Health>>(Ok(healthStatus));
    }
    
}