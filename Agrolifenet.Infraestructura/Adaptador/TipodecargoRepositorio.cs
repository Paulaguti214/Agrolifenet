using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipodecargoRepositorio : Repositorio<TiposdeCargo>, ITipodecargoRepositorio
    {
        private readonly string NombreProcedimientoGuardarTiposdecargo = "InsertarTiposdecargo";
        private readonly string NombreProcedimientoListarTiposdecargo = "ListarTiposdecargo";
        private readonly string NombreProcedimientoSeleccionarTiposdecargo = "BuscarTiposdecargo";
        private readonly string NombreProcedimientoEliminarTiposdecargo = "EliminarTiposdecargo";
        private readonly string NombreProcedimientoActualizarTiposdecargo = "ActualizarTiposdecargo";
        public TipodecargoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }
        public async Task AgregarAsync(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo, bool estadoTiposdecargo)
        {
            await AgregarAsync(NombreProcedimientoGuardarTiposdecargo, new
            {
                tipodecargo,
                fechadecreacionTiposdecargo,
                fechademodificacionTiposdecargo,
                estadoTiposdecargo

            }); 
        }
        public async  Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo()
        {
            return await ListAsync(NombreProcedimientoListarTiposdecargo);
        }
        public async Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTiposdecargo, new
            {
                idTiposdecargo
            });
        }
        public async Task EliminarTiposdecargo(int idTiposdecargo)
        {
            await EliminarAsync(NombreProcedimientoEliminarTiposdecargo, new
            {
                idTiposdecargo
            });
        }

        public async Task ActualizarTiposdecargo(int idTiposdecargo, string tipodecargo, DateTime fechademodificacionTiposdecargo, bool estadoTiposdecargo)
        {
            await ActualiozarAsync(NombreProcedimientoActualizarTiposdecargo, new
            {
                idTiposdecargo,
                tipodecargo,
                fechademodificacionTiposdecargo,
                estadoTiposdecargo
            });
        }

       

        

      

        
    }
}
