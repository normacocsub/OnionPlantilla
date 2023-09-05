using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Aplicacion.Commands;
using TiendaOnion.Dominio.Entidades;
using TiendaOnion.Infraestructura.Data.Repositories;

namespace TiendaOnion.Aplicacion.Handlers
{
    public class AgregarProductoHandler : IRequestHandler<AgregarProductoCommand, int>
    {
        private readonly IProductoRepository _productoRepository;

        public AgregarProductoHandler(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<int> Handle(AgregarProductoCommand request, CancellationToken cancellationToken)
        {
            var nuevoProducto = new Producto
            {
                Nombre = request.Nombre,
                Precio = request.Precio
            };

            await _productoRepository.AgregarProducto(nuevoProducto);

            return nuevoProducto.Id;
        }
    }
}
