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
        public int NumerotelefonicoUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public DateTime FechadecreacionUsuario { get; set; }
        public DateTime FechademodificacionUsuario { get; set; }
        public bool BloqueoUsuario { get; set; }
        public Usuario(
            int idUsuario,
            int identificacionUsuario,
            string nombreUsuario,
            string apellidoUsuario,
            DateTime fechadenacimientoUsuario,
            string correoelectronicoUsuario,
            int numerotelefonicoUsuario,
            bool estadoUsuario,
            DateTime fechadecreacionUsuario,
            DateTime fechademodificacionUsuario,
            bool bloqueoUsuario)
        {
            IdUsuario = idUsuario;
            IdentificacionUsuario = identificacionUsuario;
            NombreUsuario = nombreUsuario;
            ApellidoUsuario = apellidoUsuario;
            FechadenacimientoUsuario = fechadenacimientoUsuario;
            CorreoelectronicoUsuario = correoelectronicoUsuario;
            NumerotelefonicoUsuario = numerotelefonicoUsuario;
            FechadecreacionUsuario = fechadecreacionUsuario;
            FechademodificacionUsuario = fechademodificacionUsuario;
            BloqueoUsuario = bloqueoUsuario;
        }
        public int Guardar()
        {
            return 0;
        }
        public bool Actualizar()
        {
            return false;
        }
        public bool Eliminar()
        {
            return true;
        }
        public Usuario Buscar()
        {
            return new Usuario(default, default, default!, default!, default, default!, default, default, default, default, default);
        }
        public List<Usuario> Listar(Usuario usuario)
        {
            return new List<Usuario>();
        }



    }
}


