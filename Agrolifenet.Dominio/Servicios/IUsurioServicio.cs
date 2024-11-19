using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
namespace Agrolifenet.Dominio.Servicios
{
    public interface IUsurioServicio
    {
        Task Agregar(string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario, bool BloqueoUsuario);
        Task<IEnumerable<Usuario>> ListarUsuario();
        Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo);
        Task EliminarUsuario(int idUsuario);

        Task ActualizarUsuario(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario, bool BloqueoUsuario);

        Task<UsuarioTokenDto?> LogeoAsync(string Usuario, string Contrasenia);
    }
}
