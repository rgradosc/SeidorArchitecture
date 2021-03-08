using SeidorArchitecture.DigitalB89.Application.Interfaces;
using SeidorArchitecture.DigitalB89.Application.Main;
using SeidorArchitecture.DigitalB89.Domain.Core;
using SeidorArchitecture.DigitalB89.Domain.Interfaces;
using SeidorArchitecture.DigitalB89.Infrastructure.Data;
using SeidorArchitecture.DigitalB89.Infrastructure.Interfaces;
using SeidorArchitecture.DigitalB89.Infrastructure.Repository;
using SeidorArchitecture.DigitalB89.Transversal.Common;
using SeidorArchitecture.DigitalB89.Transversal.Mapper;
using SeidorArchitecture.DigitalB89.Services.WebAPI.Modules.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SeidorArchitecture.DigitalB89.Services.WebAPI
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
            services.AddAutoMapper(x => x.AddProfile(new AutoMapperProfile()));

            services.AddSwagger();

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddSingleton<IConnectionFactory, ConnectionFactory>();

            services.AddScoped<ICustomerApplication, CustomerApplication>();

            services.AddScoped<ICustomerDomain, CustomerDomain>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddControllers()
                .AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Seidor API Market v1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
