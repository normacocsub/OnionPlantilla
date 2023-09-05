using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOnion.Dominio.Entidades;
using TiendaOnion.Dominio.Interfaces;

namespace TiendaOnion.Dominio.Servicios
{
    public class FacturaService
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly IClienteRepository _clienteRepository;

        public FacturaService(IFacturaRepository facturaRepository, IClienteRepository clienteRepository)
        {
            _facturaRepository = facturaRepository;
            _clienteRepository = clienteRepository;
        }

        public void CrearFactura(Factura factura, int clienteId)
        {
            var cliente = _clienteRepository.ObtenerClientePorId(clienteId);
            factura.ClienteId = cliente.Id;
            factura.Fecha = DateTime.Now;

            // Lógica para calcular subtotales y totales de los detalles de factura
            // ...

            _facturaRepository.AgregarFactura(factura);
        }
    }
}
