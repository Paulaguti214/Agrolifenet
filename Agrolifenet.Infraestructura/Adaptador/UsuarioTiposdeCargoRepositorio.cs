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
        private readonly string NombreProcedimientoCargosUsuario = "CargosUsuario";

        public UsuarioTiposdeCargoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo, int IdTiposdecargo)
        {
            await ActualizarAsync(NombreProcedimientoActualizarUsuarioTiposdeCargo, new
            {
                IdUsuarioTiposdecargo,
                IdTiposdecargo
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
    }
}
