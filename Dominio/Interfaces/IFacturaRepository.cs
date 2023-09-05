using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;

namespace TiendaOnion.Dominio.Interfaces
{
    public interface IFacturaRepository
    {
        Factura ObtenerFacturaPorId(int id);
        void AgregarFactura(Factura factura);
    }
}
