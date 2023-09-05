using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;
using TiendaOnion.Dominio.Interfaces;

namespace TiendaOnion.Dominio.Servicios
{
    public class ProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public void CrearProducto(Producto producto)
        {
            // Lógica de validación del producto (por ejemplo, asegurarse de que el nombre y el precio sean válidos)

            _productoRepository.AgregarProducto(producto);
        }
    }
}
