using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipodeparametroRepositorio : Repositorio<TipodeParametro>, ITipodeparametroRepositorio
    {
        private readonly string NombreProcedimientoGuardarTipodeparametro = "InsertarTipodeparametro";
        private readonly string NombreProcedimientoListarTipodeparametro = "ListarTipodeparametro";
        private readonly string NombreProcedimientoSeleccionarTipodeparametro = "BuscarTipodeparametro";
        private readonly string NombreProcedimientoEliminarTipodeparametro = "EliminarTipodeparametro";
        private readonly string NombreProcedimientoActualizarTipodeparametro = "ActualizarTipodeparametro";
        public TipodeparametroRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }
        public async Task AgregarAsync(string Tiposdeparametros, DateTime FechadecreacionTipodeparametro, DateTime FechademodificacionTipodeparametro, bool EstadoTipodeparametro)
        {
            await AgregarAsync(NombreProcedimientoGuardarTipodeparametro, new
            {
                Tiposdeparametros,
                FechadecreacionTipodeparametro,
                FechademodificacionTipodeparametro,
                EstadoTipodeparametro
            });
        }
        public async Task<IEnumerable<TipodeParametro>> ListarTipodeparametro()
        {
            return await ListarAsync(NombreProcedimientoListarTipodeparametro);
        }
        public async Task<TipodeParametro> SeleccionarTipodeparametro(int IdTipodeparametro)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTipodeparametro, new
            {
                IdTipodeparametro
            });
        }
        public async Task EliminarTipodeparametro(int IdTipodeparametro)
        {
            await EliminarAsync(NombreProcedimientoEliminarTipodeparametro, new
            {
                IdTipodeparametro
            });
        }

        public async Task ActualizarTipodeparametro(int IdTipodeparametro, string Tiposdeparametros, DateTime FechademodificacionTipodeparametro, bool EstadoTipodeparametro)
        {
            await ActualizarAsync(NombreProcedimientoActualizarTipodeparametro, new
            {
                IdTipodeparametro,
                Tiposdeparametros,
                FechademodificacionTipodeparametro,
                EstadoTipodeparametro
            });
        }








    }
}
