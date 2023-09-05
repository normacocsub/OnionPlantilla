using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;
using TiendaOnion.Infraestructura.Data.Contexts;

namespace TiendaOnion.Infraestructura.Data.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly TiendaOnionContext _dbContext;

        public ProductoRepository(TiendaOnionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Producto> ObtenerProductoPorId(int productoId)
        {
            return await _dbContext.Productos.FindAsync(productoId);
        }

        public async Task<IEnumerable<Producto>> ObtenerTodosLosProductosAsync()
        {
            return await _dbContext.Productos.ToListAsync();
        }

        public async Task AgregarProducto(Producto producto)
        {
            await _dbContext.Productos.AddAsync(producto);
            await _dbContext.SaveChangesAsync();
            return;
        }

        public async Task ActualizarProductoAsync(Producto producto)
        {
            return;
        }

        public async Task EliminarProductoAsync(int productoId)
        {
            return;
        }
    }
}
