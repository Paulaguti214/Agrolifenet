using Agrolifenet.Dominio.Dto;
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
        private readonly string NombreProcedimientoBuscarUsuarioTiposdeCargo = "BuscarUsuarioTiposdecargo";
        private readonly string NombreProcedimientoListarUsuarioTiposdeCargo = "ListarUsuarioTiposdecargo";
        private readonly string NombreProcedimientoEliminarUsuarioTiposdeCargo = "EliminarUsuarioTipodecargo";

        private readonly string NombreProcedimientoCargosUsuario = "CargosUsuario";

        public UsuarioTiposdeCargoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo, int IdUsuario)
        {
            await ActualizarAsync(NombreProcedimientoActualizarUsuarioTiposdeCargo, new
            {
                IdUsuarioTiposdecargo,
                IdTiposdecargo,
                IdUsuario
            });
        }

        public async Task AgregarUsuarioTiposdeCargoAsync(int IdUsuario, int IdTiposdecargo)
        {
            await AgregarAsync(NombreProcedimientoGuardarUsuarioTiposdeCargo, new
            {
                IdUsuario,
                IdTiposdecargo
            });
        }

        public async Task<IEnumerable<CargosUsuarioDto>> CargosUsuarioAsync(int IdUsuario)
        {
            return await ListarAsync<CargosUsuarioDto>(NombreProcedimientoCargosUsuario, new { IdUsuario });
        }



        public async Task EliminarUsuariosTiposdecargoAsync(int IdUsuarioTiposdecargo)
        {
            await EliminarAsync(NombreProcedimientoEliminarUsuarioTiposdeCargo, new
            {
                IdUsuarioTiposdecargo
            });
        }

        public async Task<IEnumerable<UsuarioTiposdeCargo>> ListarUsuariosTiposdecargoAsync()
        {
            return await ListarAsync(NombreProcedimientoListarUsuarioTiposdeCargo);
        }
    }
}
