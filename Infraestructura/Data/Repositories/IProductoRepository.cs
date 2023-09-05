using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;

namespace TiendaOnion.Infraestructura.Data.Repositories
{
    public interface IProductoRepository
    {
        Task<Producto> ObtenerProductoPorId(int productoId);
        Task<IEnumerable<Producto>> ObtenerTodosLosProductosAsync();
        Task AgregarProducto(Producto producto);
        Task ActualizarProductoAsync(Producto producto);
        Task EliminarProductoAsync(int productoId);
    }
}
