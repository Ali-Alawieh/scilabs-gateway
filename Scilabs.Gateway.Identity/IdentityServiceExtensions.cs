using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scilabs.Gateway.Identity.Models;

namespace Scilabs.Gateway.Identity;

public static class IdentityServiceExtensions
{

    public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);

        services.AddAuthorizationBuilder();

        services.AddDbContext<ScilabsGatewayIdentityDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("ScilabsIdentityConnectionString")));



        services.AddIdentityCore<ApplicationUser>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;
            }).AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ScilabsGatewayIdentityDbContext>().AddApiEndpoints();
    }
    
}