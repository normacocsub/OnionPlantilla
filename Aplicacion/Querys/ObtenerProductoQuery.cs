using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Aplicacion.DTOs;

namespace TiendaOnion.Aplicacion.Querys
{
    public record ObtenerProductoQuery(int ProductoId) : IRequest<ProductoDto>;
}
