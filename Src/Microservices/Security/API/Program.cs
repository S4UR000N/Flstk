using Cross.API.Application.DependencyInjection;
using Cross.API.Security.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.AddControllers();
builder.AddOpenApi();
builder.AddAuth();

var app = builder.Build();

app.UseOpenApiDev();

app.UseHttpsRedirection();
app.UseAuth();
app.MapControllers();

app.Run();