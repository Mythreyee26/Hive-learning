var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Read environment variables
var message = Environment.GetEnvironmentVariable("MESSAGE") ?? "No MESSAGE provided";
var env = Environment.GetEnvironmentVariable("DOTNET_ENV") ?? "No DOTNET_ENV provided";

app.MapGet("/", () => new
{
    MESSAGE = message,
    DOTNET_ENV = env
});

app.Run();
