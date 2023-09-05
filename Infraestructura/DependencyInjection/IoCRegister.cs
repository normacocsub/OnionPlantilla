using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Infraestructura.Data.Repositories;

namespace TiendaOnion.Infraestructura.DependencyInjection
{
    public static class IoCRegistrar
    {
        public static void RegistrarServicios(IServiceCollection services)
        {
            // Registrar los servicios y dependencias aquí
            services.AddScoped<IProductoRepository, ProductoRepository>();
            //services.AddScoped<IFacturaRepository, FacturaRepository>();
            //services.AddScoped<IClienteRepository, ClienteRepository>();

            // Otros registros
        }
    }
}
