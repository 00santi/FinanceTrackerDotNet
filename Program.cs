var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", Health);

app.Run();

static IResult Health()
{
    return Results.Ok("Server Running");
}
