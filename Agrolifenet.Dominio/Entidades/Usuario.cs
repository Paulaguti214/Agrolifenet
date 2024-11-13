using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Entidades
{

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdentificacionUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public DateTime FechadenacimientoUsuario { get; set; }
        public string CorreoelectronicoUsuario { get; set; }
        public string NumerotelefonicoUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public DateTime FechadecreacionUsuario { get; set; }
        public DateTime FechademodificacionUsuario { get; set; }
        public bool BloqueoUsuario { get; set; }
        
    }
}


