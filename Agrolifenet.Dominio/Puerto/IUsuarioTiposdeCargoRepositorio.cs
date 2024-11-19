using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IUsuarioTiposdeCargoRepositorio
    {
        Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo);
        Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario);
    }
}
