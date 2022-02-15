using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using ResidenceManagement.Application.Extentions;
using ResidenceManagement.Application.Settings;
using ResidenceManagement.Domain.Entities.Auths;
using ResidenceManagement.Infrastructure.Persistence;
using System;

namespace ResidenceManagement.API
{
    public static class ApiServiceRegistration
    {
        public static IServiceCollection AddApiService(this IServiceCollection services,
             IConfiguration configuration)
        {
            #region Settings

            services.Configure<JwtSettings>(configuration.GetSection("JWT"));
            var jwt = configuration.GetSection("JWT").Get<JwtSettings>();


            #endregion

            #region Kullanıcı şifre kısıtlama
            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
                options.Lockout.MaxFailedAccessAttempts = 5;

            }).AddEntityFrameworkStores<SiteContext>().AddDefaultTokenProviders();

            #endregion

            services.ConfigureCors();

            services.AddAuth(jwt);
            services.AddAuthorization(options =>
            {

                options.AddPolicy("Admin",
                    authBuilder =>
                    {
                        authBuilder.RequireRole("Administrators");
                    });

            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Scheme = "bearer"
                });
                c.OperationFilter<AuthorizationHeaderParameterOperationFilter>();


            });


            return services;
        }

    }
}
