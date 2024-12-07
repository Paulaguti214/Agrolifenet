using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class UsuarioTiposdeCargoServicio : IUsuarioTiposdeCargoServicio
    {
        private readonly IUsuarioTiposdeCargoRepositorio _usuarioTiposdeCargoRepositorio;

        public UsuarioTiposdeCargoServicio(IUsuarioTiposdeCargoRepositorio usuarioTiposdeCargoRepositorio)
        {
            _usuarioTiposdeCargoRepositorio = usuarioTiposdeCargoRepositorio;
        }

        public async Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo, int IdUsuario)
        {
            await _usuarioTiposdeCargoRepositorio.ActualizarUsuarioTiposdeCargoAsync(IdUsuarioTiposdecargo, IdTiposdecargo, IdUsuario);
        }

        public async Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo)
        {
            await _usuarioTiposdeCargoRepositorio.AgregarUsuarioTiposdeCargoAsync(IdUsuario, IdTiposdecargo);
        }

        public async Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario)
        {
            return await _usuarioTiposdeCargoRepositorio.CargosUsuarioAsync(IdUsuario);
        }

        public async Task EliminarUsuariosTiposdecargoAsync(int IdUsuarioTiposdecargo)
        {
            await _usuarioTiposdeCargoRepositorio.EliminarUsuariosTiposdecargoAsync(IdUsuarioTiposdecargo);
        }

        public Task<IEnumerable<UsuarioTiposdeCargo>> ListarUsuariosTiposdecargoAsync()
        {
            return _usuarioTiposdeCargoRepositorio.ListarUsuariosTiposdecargoAsync();
        }
    }
}
