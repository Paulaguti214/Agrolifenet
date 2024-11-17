using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class UsuarioTiposdeCargoRepositorio : Repositorio<UsuarioTiposdeCargo>, IUsuarioTiposdeCargoRepositorio
    {
        private readonly string NombreProcedimientoGuardarUsuarioTiposdeCargo = "InsertarUsuarioTiposdecargo";
        private readonly string NombreProcedimientoActualizarUsuarioTiposdeCargo = "ActualizarUsuarioTiposdecargo";


        public UsuarioTiposdeCargoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarUsuarioTiposdeCargo(int IdUsuarioTiposdecargo, int IdTiposdecargo)
        {
            await ActualiozarAsync(NombreProcedimientoActualizarUsuarioTiposdeCargo, new
            {
                IdUsuarioTiposdecargo,
                IdTiposdecargo
            });
        }

        public async Task AgregarUsuarioTiposdeCargo(int IdUsuario, int IdTiposdecargo)
        {
            await AgregarAsync(NombreProcedimientoGuardarUsuarioTiposdeCargo, new
            {
                IdUsuario,
                IdTiposdecargo
            });
        }
    }
}
