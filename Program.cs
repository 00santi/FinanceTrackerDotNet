static void Main(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);

    var app = builder.Build();

    app.MapGet("/health", Health);
    //app.MapGet("/other", other);
    //app.MapGet("/another", anoter);
    //app.MapGet("/someother", someother);

    app.Run();
}

static IResult Health()
{
    return Results.Ok("Server Running");
}

Main([]);
