using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class DatosdeReproduccionRepositorio : Repositorio<DatosdeReproduccion>, IDatosdeReproduccionRepositorio
    {
        private readonly string NombreProcedimientoGuardarDatosdeReproduccion = "InsertarDatosdereproduccion";
        private readonly string NombreProcedimientoListarDatosdeReproduccion = "ListarDatosdereproduccion";
        private readonly string NombreProcedimientoBuscarDatosdeReproduccion = "BuscarDatosdereproduccion";
        private readonly string NombreProcedimientoEliminarDatosdeReproduccion = "EliminarDatosdereproduccion";
        private readonly string NombreProcedimientoActualizarDatosdeReproduccion = "ActualizarDatosdereproduccion";

        public DatosdeReproduccionRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarDatosdeReproduccion(int IdDatosdereproduccion, int IdRepruductorDatosdereproduccion, bool Resultadodelareproduccion, string ObservacionesDatosdereproduccion, bool EstadoDatosdereproduccion, DateTime Fechadelprocesodereproduccion, DateTime FechadecreacionDatosdereproduccion, DateTime FechademodificacionDatosdereproduccion, int IdTipodereproduccion)
        {
            await ActualizarAsync(NombreProcedimientoActualizarDatosdeReproduccion, new
            {
                IdDatosdereproduccion,
                IdRepruductorDatosdereproduccion,
                Resultadodelareproduccion,
                ObservacionesDatosdereproduccion,
                EstadoDatosdereproduccion,
                Fechadelprocesodereproduccion,
                FechadecreacionDatosdereproduccion,
                FechademodificacionDatosdereproduccion,
                IdTipodereproduccion
            });
        }

        public async Task AgregarDatosdeReproduccion(int IdRepruductor, bool Resultadodelareproduccion, string ObservacionesDatosdereproduccion, bool EstadoDatosdereproduccion, DateTime Fechadelprocesodereproduccion, DateTime FechadecreacionDatosdereproduccion, DateTime FechademodificacionDatosdereproduccion, int IdTipodereproduccion)
        {
            await AgregarAsync(NombreProcedimientoGuardarDatosdeReproduccion, new
            {
                IdRepruductor,
                Resultadodelareproduccion,
                ObservacionesDatosdereproduccion,
                EstadoDatosdereproduccion,
                Fechadelprocesodereproduccion,
                FechadecreacionDatosdereproduccion,
                FechademodificacionDatosdereproduccion,
                IdTipodereproduccion
            });
        }

        public async Task<DatosReproduccionDto> BuscarDatosdeReproduccion(int IdDatosdereproduccion)
        {
            return await SeleccionarAsync<DatosReproduccionDto>(NombreProcedimientoBuscarDatosdeReproduccion, new { IdDatosdereproduccion });
        }

        public async Task EliminarDatosdeReproduccion(int IdDatosdereproduccion)
        {
            await EliminarAsync(NombreProcedimientoEliminarDatosdeReproduccion, new { IdDatosdereproduccion });
        }

        public async Task<IEnumerable<DatosReproduccionDto>> ListarDatosdeReproduccion(int IdGanado)
        {
            return await ListarAsync<DatosReproduccionDto>(NombreProcedimientoListarDatosdeReproduccion, new { IdGanado });
        }
    }
}
