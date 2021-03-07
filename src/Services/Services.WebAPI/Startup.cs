using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SeidorArchitecture.ECommerce.Application.Interfaces;
using SeidorArchitecture.ECommerce.Application.Main;
using SeidorArchitecture.ECommerce.Domain.Core;
using SeidorArchitecture.ECommerce.Domain.Interfaces;
using SeidorArchitecture.ECommerce.Infrastructure.Data;
using SeidorArchitecture.ECommerce.Infrastructure.Interfaces;
using SeidorArchitecture.ECommerce.Infrastructure.Repository;
using SeidorArchitecture.ECommerce.Transversal.Common;
using SeidorArchitecture.ECommerce.Transversal.Mapper;
using Services.WebAPI.Modules.Swagger;

namespace Services.WebAPI
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
