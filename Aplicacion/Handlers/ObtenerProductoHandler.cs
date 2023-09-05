using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Aplicacion.DTOs;
using TiendaOnion.Aplicacion.Querys;
using TiendaOnion.Infraestructura.Data.Repositories;

namespace TiendaOnion.Aplicacion.Handlers
{
    public class ObtenerProductoHandler : IRequestHandler<ObtenerProductoQuery, ProductoDto>
    {
        private readonly IProductoRepository _productoRepository;

        public ObtenerProductoHandler(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<ProductoDto> Handle(ObtenerProductoQuery request, CancellationToken cancellationToken)
        {
            var producto = await _productoRepository.ObtenerProductoPorId(request.ProductoId);

            if (producto == null)
            {
                return null;
            }

            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio
            };
        }
    }
}
