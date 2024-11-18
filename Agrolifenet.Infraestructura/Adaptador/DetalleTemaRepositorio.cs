using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class DetalleTemaRepositorio : Repositorio<DetalledeTema>, IDetalleTemaRepositorio
    {
        private readonly string NombreProcedimientoGuardarDetalleTema = "InsertarDetalledetema";
        private readonly string NombreProcedimientoListarDetalleTema = "ListarDetalledetema";
        private readonly string NombreProcedimientoBuscarDetalleTema = "BuscarDetalledetema";
        private readonly string NombreProcedimientoEliminarDetalleTema = "EliminarDetalledetema";
        private readonly string NombreProcedimientoActualizarDetalleTema = "ActualizarDetalledetema";

        public DetalleTemaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarDetalleTema(int IdDetalledetema, DateTime FechademodificacionDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            await ActualizarAsync(NombreProcedimientoActualizarDetalleTema, new
            {
                IdDetalledetema,
                FechademodificacionDetalledetema,
                EstadoDetalledetema,
                IdTemadeconsulta,
                EspecificacionDetalledetema
            });
        }

        public async Task AgregarDetalleTema(DateTime FechadecreacionDetalledetema, DateTime FechademodificacionDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            await AgregarAsync(NombreProcedimientoGuardarDetalleTema, new
            {
                FechadecreacionDetalledetema,
                FechademodificacionDetalledetema,
                EstadoDetalledetema,
                IdTemadeconsulta,
                EspecificacionDetalledetema
            });
        }

        public async Task<DetalleTemaDto> BuscarDetalledetema(int IdDetalledetema)
        {
            return await SeleccionarAsync<DetalleTemaDto>(NombreProcedimientoBuscarDetalleTema, new { IdDetalledetema });
        }

        public async Task EliminarDetalleTema(int IdDetalledetema)
        {
            await EliminarAsync(NombreProcedimientoEliminarDetalleTema, new { IdDetalledetema });
        }

        public async Task<IEnumerable<DetalleTemaDto>> ListarDetalleTema(int IdTemadeconsulta)
        {
            return await ListarAsync<DetalleTemaDto>(NombreProcedimientoListarDetalleTema, new { IdTemadeconsulta });
        }
    }
}
