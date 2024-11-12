using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class UsuarioServicio : IUsurioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task Agregar(int IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario,  bool BloqueoUsuario)
        {
            var fechaActual = DateTime.Now;

            await _usuarioRepositorio.AgregarAsync(IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, EstadoUsuario, fechaActual, fechaActual, BloqueoUsuario);

        }
    }
}
