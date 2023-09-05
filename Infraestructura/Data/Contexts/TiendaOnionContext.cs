using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;
using TiendaOnion.Infraestructura.Data.Configurations;

namespace TiendaOnion.Infraestructura.Data.Contexts
{
    public class TiendaOnionContext : DbContext
    {
        public TiendaOnionContext(DbContextOptions<TiendaOnionContext> options)
            : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
