using Microsoft.Extensions.DependencyInjection;

namespace Scilabs.Gateway.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection service)
    {
        service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        service.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        return service;
    }
}