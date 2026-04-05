using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scalar.AspNetCore;

namespace Cross.API.Application.DependencyInjection;

public static class OpenApiDI
{
    public static WebApplicationBuilder AddOpenApi(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();

        return builder;
    }

    public static WebApplication UseOpenApiDev(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();                                                                       // https://localhost:6443/openapi/v1.json
            app.MapScalarApiReference();                                                            // https://localhost:6443/scalar/v1
        }

        return app;
    }
}
