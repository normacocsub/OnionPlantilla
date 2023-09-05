using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;

namespace TiendaOnion.Dominio.Interfaces
{
    public interface IProductoRepository
    {
        Task<Producto> ObtenerProductoPorId(int id);
        List<Producto> ObtenerTodosLosProductos();
        Task<int> AgregarProducto(Producto producto);
    }
}
