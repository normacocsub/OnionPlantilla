using MediatR;
using Microsoft.AspNetCore.Mvc;
using TiendaOnion.Aplicacion.Commands;
using TiendaOnion.Aplicacion.Querys;

namespace TiendaOnion.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AgregarProducto([FromBody] AgregarProductoCommand command)
        {
            var productoId = await _mediator.Send(command);
            return Ok(productoId);
        }

        [HttpGet("{productoId}")]
        public async Task<IActionResult> ObtenerProducto(int productoId)
        {
            var consulta = new ObtenerProductoQuery(productoId) { ProductoId = productoId };
            var producto = await _mediator.Send(consulta);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }
    }
}
