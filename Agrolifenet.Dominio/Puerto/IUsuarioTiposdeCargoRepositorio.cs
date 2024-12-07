using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IUsuarioTiposdeCargoRepositorio
    {
        Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo, int IdUsuario);

        Task<IEnumerable<UsuarioTiposdeCargo>> ListarUsuariosTiposdecargoAsync();
        Task EliminarUsuariosTiposdecargoAsync(int IdUsuarioTiposdecargo);
        Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario);


    }
}
