using System;
using Application.Contracts.Repository;
using Application.Contracts.Services;
using Infrastructure;
using Infrastructure.Contracts.Repository;
using Infrastructure.Contracts.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
namespace API
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


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            // services.AddScoped<ICategoryService, CategoryManager>();
            // services.AddScoped<ICategoryDal, EfCategoryDal>();
            //services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();

            //services.AddScoped<IBookService, BookService>();
            //services.AddScoped<IBookRepository, BookRepository>();

            //services.AddScoped<IAuthorService,AuthorService>();
            //services.AddScoped<IAuthorRepository, AuthorRepository>();

            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
