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
        public async Task Agregar(string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario, bool BloqueoUsuario)
        {
            var fechaActual = DateTime.Now;

            await _usuarioRepositorio.AgregarAsync(IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, EstadoUsuario, fechaActual, fechaActual, BloqueoUsuario);

        }
        public Task<IEnumerable<Usuario>> ListarUsuario()
        {
            return _usuarioRepositorio.ListarUsuario();

        }

        public Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo)
        {
            return _usuarioRepositorio.SeleccionarUsuario(identificacionUsuario, tipodecargo);
        }

        public async Task EliminarUsuario(int idUsuario)
        {
            await _usuarioRepositorio.EliminarUsuario(idUsuario);
        }


        public async Task ActualizarUsuario(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario, bool BloqueoUsuario)
        {
            var fechaActual = DateTime.Now;
            await _usuarioRepositorio.ActualizarUsuario(idUsuario, IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, fechaActual, EstadoUsuario, BloqueoUsuario);
        }

        public async Task<Usuario> Logeo(string Usuario, string Contrasenia)
        {
            //await _usuarioRepositorio.Logeo(Usuario, Contrasenia);
            await Task.Delay(300);
            return new Usuario() { IdentificacionUsuario = 1020 };
        }
    }
}
