using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.OpenApi.Models;
using Runpath.Data;
using Runpath.Data.Repository;
using Runpath.Data.Services;
using Runpath.Shared.Interfaces;
using Runpath.Shared.Services;

namespace Runpath.API.Extensions
{
    public static class ServiceConfigExtensions
    {
        public static IServiceCollection AddSystemServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Runpath API",
                    Version = "v1",
                    Description = "ASP.Net Core 3 API for the Runpath interview",
                    Contact = new OpenApiContact
                    {
                        Name = "Chad Bonthuys",
                        Email = "chad@atomixdev.com",
                        Url = new Uri("https://www.linkedin.com/in/chadbonthuys/"),
                    },
                });
            });

            services.AddScoped<EFRepository>();
            services.AddScoped<RepositoryService>();
            services.AddEntityFrameworkSqlite().AddDbContext<RunpathDBContext>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}