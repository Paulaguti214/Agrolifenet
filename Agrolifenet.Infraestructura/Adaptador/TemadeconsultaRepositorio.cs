using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TemadeconsultaRepositorio : Repositorio<TemadeConsulta>, ITemadeconsultaRepositorio
    {
        private readonly string NombreProcedimientoGuardarTemadeconsulta = "InsertarTemadeconsulta";
        private readonly string NombreProcedimientoListarTemadeconsulta = "ListarTemadeconsulta";
        private readonly string NombreProcedimientoSeleccionarTemadeconsulta = "BuscarTemadeconsulta";
        private readonly string NombreProcedimientoEliminarTemadeconsulta = "EliminarTemadeconsulta";
        private readonly string NombreProcedimientoActualizarTemadeconsulta = "ActualizarTemadeconsulta";


        public TemadeconsultaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }
        public async Task AgregarTemadeconsulta(DateTime FechadecreacionTemadeconsulta, DateTime FechademodificacionTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta)
        {
            await AgregarAsync(NombreProcedimientoGuardarTemadeconsulta, new
            {
                FechadecreacionTemadeconsulta,
                FechademodificacionTemadeconsulta,
                EstadoTemadeconsulta,
                Temasdeconsulta
            });
        }
        public async Task<IEnumerable<TemadeConsulta>> ListarTemadeconsulta()
        {
            return await ListarAsync(NombreProcedimientoListarTemadeconsulta);
        }
        public async Task<TemadeConsulta> SeleccionTemadeconsulta(int IdTemadeconsulta)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTemadeconsulta, new
            {
                IdTemadeconsulta
            });
        }
        public async Task EliminarTemadeconsulta(int IdTemadeconsulta)
        {
            await EliminarAsync(NombreProcedimientoEliminarTemadeconsulta, new
            {
                IdTemadeconsulta
            });
        }

        public async Task ActualizarTemadeconsulta(int IdTemadeconsulta, DateTime FechademodificacionTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta)
        {
            await ActualiozarAsync(NombreProcedimientoActualizarTemadeconsulta, new
            {
                IdTemadeconsulta,
                FechademodificacionTemadeconsulta,
                EstadoTemadeconsulta,
                Temasdeconsulta
            });
        }








    }
}
