using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnion.Infraestructura.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? NombreCompleto { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Constructor
        public ApplicationUser()
        {
            FechaRegistro = DateTime.Now;
        }
    }
}
