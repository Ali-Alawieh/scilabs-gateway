namespace Scilabs.Gateway.Api.Middleware;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _next;
    private const string _apiKeyName = "XScilabsApiKey";

    public ApiKeyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IConfiguration config)
    {
        
        var apiKeyPresentInHeader = context.Request.Headers
            .TryGetValue(_apiKeyName, out var extractedApiKey);
        var apiKey = config[_apiKeyName];

        if ((apiKeyPresentInHeader && apiKey == extractedApiKey) || context.Request.Path.StartsWithSegments("/swagger") || context.Request.Path.StartsWithSegments("/health"))
        {
            await _next(context);
            return;
        }

        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Authorization Failed");
    }
    
}