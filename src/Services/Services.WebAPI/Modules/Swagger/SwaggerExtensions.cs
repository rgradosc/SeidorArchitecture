using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Services.WebAPI.Modules.Swagger
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Seidor Technology Services API Market",
                    Version = "v1",
                    Description = "Web API construido como parte del examen técnico de Seidor Perú para el puesto de Desarrollador .NET",
                    Contact = new OpenApiContact
                    {
                        Email = "grados_2008@hotmail.com",
                        Name = "Raúl Grados Carreño",
                        Url = new Uri("https://www.rgradosc.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "General Public License v3",
                        Url = new Uri("https://www.gnulicense.com"),
                    }
                });

                config.AddSecurityDefinition("Authorization", new OpenApiSecurityScheme
                {
                    Description = "Authorization by API key",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Name = "Authorization"
                });

                config.AddSecurityRequirement(new OpenApiSecurityRequirement());
            });

            return services;
        }
    }
}
