using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ResidenceManagement.Application;
using ResidenceManagement.Infrastructure;
using ResidenceManagement.Infrastructure.Middlewares;
using ResidenceManagement.Infrastructure.Middlewares.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidenceManagement.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInfrastructureServices(Configuration);
            services.AddApplicationService(Configuration);
            services.AddApiService(Configuration);

            services.AddControllers();
        
            services.AddCors(options =>
                 options.AddDefaultPolicy(builder =>
                 builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

                        //    services.AddSwaggerGen(c =>
            //    {
            //        c.SwaggerDoc("v1", new OpenApiInfo { Title = "ResidenceManagement.API", Version = "v1" });
            //    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ResidenceManagement.API v1"));
            }
            //app.ConfigureCustomExceptionMiddleware();
            app.UseMiddleware(typeof(ExceptionHandlingMiddleware));

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader());


            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
