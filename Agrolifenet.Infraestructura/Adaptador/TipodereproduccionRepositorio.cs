using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipodereproduccionRepositorio : Repositorio<TipodeReproduccion>, ITipodereproduccionRepositorio
    {
        private readonly string NombreProcedimientoGuardarTipodereproduccion = "InsertarTipodereproduccion";
        private readonly string NombreProcedimientoListarTipodereproduccion = "ListarTipodereproduccion";
        private readonly string NombreProcedimientoSeleccionarTipodereproduccion = "BuscarTipodereproduccion";
        private readonly string NombreProcedimientoEliminarTipodereproduccion = "EliminarTipodereproduccion";
        private readonly string NombreProcedimientoActualizarTipodereproduccion = "ActualizarTiposdereproduccion";
        public TipodereproduccionRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }
        public async Task AgregarAsync(string Tiposdereproduccion, bool EstadoTipodereproduccion, DateTime FechadecreacionTipodereproduccion, DateTime FechademodificacionTipodereproduccion)
        {
            await AgregarAsync(NombreProcedimientoGuardarTipodereproduccion, new
            {
                Tiposdereproduccion,
                EstadoTipodereproduccion,
                FechadecreacionTipodereproduccion,
                FechademodificacionTipodereproduccion
            });

        }
        public async Task<IEnumerable<TipodeReproduccion>> ListarTipodereproduccion()
        {
            return await ListarAsync(NombreProcedimientoListarTipodereproduccion);
        }
        public async Task<TipodeReproduccion> SeleccionarTipodereproduccion(int IdTipodereproduccion)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTipodereproduccion, new
            {
                IdTipodereproduccion
            });


        }
        public async Task EliminarTipodereproduccion(int IdTipodereproduccion)
        {
            await EliminarAsync(NombreProcedimientoEliminarTipodereproduccion, new
            {
                IdTipodereproduccion
            });
        }
        public async Task ActualizarTipodereproduccion(int IdTipodereproduccion, string Tiposdereproduccion, bool EstadoTipodereproduccion, DateTime FechademodificacionTipodereproduccion)
        {
            await ActualizarAsync(NombreProcedimientoActualizarTipodereproduccion, new
            {
                IdTipodereproduccion,
                Tiposdereproduccion,
                EstadoTipodereproduccion,
                FechademodificacionTipodereproduccion
            });
        }


    }
}
