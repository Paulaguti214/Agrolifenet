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

        public async Task ActualizarUsuarioTiposdeCargo(int IdUsuarioTiposdecargo, int IdTiposdecargo)
        {
            await _usuarioTiposdeCargoRepositorio.ActualizarUsuarioTiposdeCargo(IdUsuarioTiposdecargo, IdTiposdecargo);
        }

        public async Task AgregarUsuarioTiposdeCargo(int IdUsuario, int IdTiposdecargo)
        {
            await _usuarioTiposdeCargoRepositorio.AgregarUsuarioTiposdeCargo(IdUsuario, IdTiposdecargo);
        }
    }
}
