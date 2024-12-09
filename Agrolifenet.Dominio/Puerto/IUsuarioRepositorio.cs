using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Task AgregarAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> ListarUsuario();
        Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo);

        Task EliminarUsuario(int idUsuario);

        Task ActualizarUsuario(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, DateTime Fechademodificacion,
             bool EstadoUsuario, bool BloqueoUsuario);

        Task<Usuario> Logeo(string Usuario, string Contrasenia);

    }
}
