using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IUsuarioTiposdeCargoServicio
    {
        Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo);
        Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo);
        Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario);
    }
}
