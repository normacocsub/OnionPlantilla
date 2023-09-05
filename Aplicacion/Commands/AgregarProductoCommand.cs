using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnion.Aplicacion.Commands
{
    public class AgregarProductoCommand : IRequest<int>
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
