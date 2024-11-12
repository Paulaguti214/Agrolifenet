using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Task AgregarAsync(int IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario, DateTime FechadecreacionUsuario, DateTime Fechademodificacion, bool BloqueoUsuario);
        Task<IEnumerable<Usuario>> ListarUsuario();
        Task<Usuario> SeleccionarUsuario(int idTipoanimal);

        Task EliminarUsuario(int idTipoanimal);

        Task ActualizarUsuario(int idTipoanimal, string tiposdeanimal, DateTime fechademodificacionTipoanimal,
            Boolean estadoTipoanimal);

    }
}
