var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");*/

// Middlware A
app.Use(async (context, next) =>
{
    context.Response.WriteAsync("Middleware A => ");
    await next();
    context.Response.WriteAsync("Middleware A (End)");
});

// Middleware B
app.Use(async (context, next) =>
{
    context.Response.WriteAsync("Middleware B => ");
    await next();
    context.Response.WriteAsync("Middleware B (End) => ");
});

// Middleware C
app.Use(async (context, next) =>
{
    context.Response.WriteAsync("Middleware C => ");
    await next();
    context.Response.WriteAsync("Middlware C (End) => ");
});

app.Run();
