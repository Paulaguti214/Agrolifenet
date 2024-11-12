using Agrolifenet.Dominio.Entidades;
namespace Agrolifenet.Dominio.Servicios
{
    public interface IUsurioServicio
    {
        Task Agregar(int IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario,  bool BloqueoUsuario);
    }
}
