using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnion.Dominio.Interfaces
{
    public interface IAuthService
    {
        bool AutenticarUsuario(string usuario, string contraseña);
    }
}
