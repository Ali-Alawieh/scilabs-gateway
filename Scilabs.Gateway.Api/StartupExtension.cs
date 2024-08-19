using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Scilabs.Gateway.Api.Middleware;
using Scilabs.Gateway.Application;
using Scilabs.Gateway.Identity;
using Scilabs.Gateway.Identity.Models;
using Scilabs.Gateway.Persistence;

namespace Scilabs.Gateway.Api;

public static class StartupExtension
{
    public static WebApplication ConfigureServices(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddApplicationServices();
        builder.Services.AddPersistenceServices(builder.Configuration);
        //builder.Services.AddIdentityServices(builder.Configuration);

        builder.Services.AddCors(
            options => options.AddPolicy(
                "open",
                policy => policy.WithOrigins([
                        builder.Configuration["ApiUrl"] ?? "https://localhost:7081",
                        builder.Configuration["BlazorUrl"] ?? "https://localhost:7080"
                    ])
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(pol => true)
                    .AllowAnyHeader()
                    .AllowCredentials()));

        builder.Services.AddHttpContextAccessor();
        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                Name = "XScilabsApiKey",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });
            
            options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
            {
                {
                    new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                    {
                        Reference = new Microsoft.OpenApi.Models.OpenApiReference
                        {
                            Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                            Id = "Bearer",
                            
                        }
                    },
                    new string[] {}
                }
            });
        } );
        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        /*app.MapIdentityApi<ApplicationUser>();

        app.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInManager) =>
        {
            await signInManager.SignOutAsync();
            return TypedResults.Ok();
        });*/

        app.UseCors("open");

        /*if (app.Environment.IsxwDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }*/
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseCustomExceptionHandler();
        app.UseAuthorization();
        app.UseHttpsRedirection();
        app.MapControllers();

        return app;
    }
}