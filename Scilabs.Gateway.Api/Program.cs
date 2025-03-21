using Scilabs.Gateway.Api;
using Serilog;


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().WriteTo.File("./logs.txt")
    .CreateBootstrapLogger();

Log.Information("Scilabs Gateway API starting");

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseSerilog(
    (context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
        .WriteTo.Console(),
    true
);

var app = builder.ConfigureServices().ConfigurePipeline();

app.UseSerilogRequestLogging();


app.Run();

public partial class Program
{
}