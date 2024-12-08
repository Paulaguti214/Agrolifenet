using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IUsuarioTiposdeCargoServicio
    {
        Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo, int IdUsuario);
        Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario);

        Task<IEnumerable<UsuarioTiposdeCargo>> ListarUsuariosTiposdecargoAsync();
        Task EliminarUsuariosTiposdecargoAsync(int IdUsuarioTiposdecargo);
    }
}
