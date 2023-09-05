using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;

using TiendaOnion.Aplicacion.Handlers;
using TiendaOnion.Infraestructura.DependencyInjection;
using TiendaOnion.Infraestructura.Extensions;
using System.Reflection;
using TiendaOnion.Infraestructura.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using TiendaOnion.Infraestructura.Data.Contexts;

namespace TiendaOnion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TiendaOnionContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Configurar Mediator
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<AgregarProductoHandler>();
                cfg.RegisterServicesFromAssemblyContaining<ObtenerProductoHandler>();
                cfg.Lifetime = ServiceLifetime.Scoped;
            });

            services.AddInfrastructureServices();
            services.AddCustomServices();
            services.AddSwagger();


            // Repositorios
            services.AddScoped<IProductoRepository, ProductoRepository>();
            //services.AddScoped<IFacturaRepository, FacturaRepository>();
            //services.AddScoped<IClienteRepository, ClienteRepository>();


            // Agregar otros servicios y configuraciones

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Configuraciones adicionales

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
