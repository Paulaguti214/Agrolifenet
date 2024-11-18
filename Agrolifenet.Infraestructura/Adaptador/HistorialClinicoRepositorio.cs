using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    internal class HistorialClinicoRepositorio : Repositorio<HistorialClinico>, IHistorialClinicoRepositorio
    {
        private readonly string NombreProcedimientoGuardarHistorialClinico = "InsertarHistorialclinico";
        private readonly string NombreProcedimientoSeleccionarHistorialClinico = "BuscarHistorialclinico";
        private readonly string NombreProcedimientoEliminarHistorialClinico = "EliminarHistorialclinico";
        private readonly string NombreProcedimientoActualizarHistorialClinico = "ActualizarHistorialclinico";
        private readonly string NombreProcedimientoListarHistorialClinico = "ListarHistorialclinico";

        public HistorialClinicoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarHistorialClinico(int idHistorialClinico, DateTime fechaCreacion, DateTime fechaModificacion, bool estado, string vacunas, string tratamientos, string enfermedades, string resultadosExamenes, string infoDesparacitacion, int pesoAlNacer, int pesoActual, int gananciaPesoDiaria, string observaciones, string estadoSalud, decimal costoTratamiento, string seguimiento, int numeroPartos, int idGanado, int idUsuario, int idDatosReproduccion)
        {
            await ActualizarAsync(NombreProcedimientoActualizarHistorialClinico, new
            {
                idHistorialClinico,
                fechaCreacion,
                fechaModificacion,
                estado,
                vacunas,
                tratamientos,
                enfermedades,
                resultadosExamenes,
                infoDesparacitacion,
                pesoAlNacer,
                pesoActual,
                gananciaPesoDiaria,
                observaciones,
                estadoSalud,
                costoTratamiento,
                seguimiento,
                numeroPartos,
                idGanado,
                idUsuario,
                idDatosReproduccion
            });
        }

        public async Task AgregarHistorialClinico(DateTime fechaCreacion, DateTime fechaModificacion, bool estado, string vacunas, string tratamientos, string enfermedades, string resultadosExamenes, string infoDesparacitacion, int pesoAlNacer, int pesoActual, int gananciaPesoDiaria, string observaciones, string estadoSalud, decimal costoTratamiento, string seguimiento, int numeroPartos, int idGanado, int idUsuario, int idDatosReproduccion)
        {
            await AgregarAsync(NombreProcedimientoGuardarHistorialClinico, new
            {
                fechaCreacion,
                fechaModificacion,
                estado,
                vacunas,
                tratamientos,
                enfermedades,
                resultadosExamenes,
                infoDesparacitacion,
                pesoAlNacer,
                pesoActual,
                gananciaPesoDiaria,
                observaciones,
                estadoSalud,
                costoTratamiento,
                seguimiento,
                numeroPartos,
                idGanado,
                idUsuario,
                idDatosReproduccion
            });
        }

        public async Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico)
        {
            return await SeleccionarAsync<HistorialClinicoDto>(NombreProcedimientoSeleccionarHistorialClinico, new
            {
                IdHistorialclinico
            });
        }

        public async Task EliminarHistorialClinico(int IdHistorialclinico)
        {
            await EliminarAsync(NombreProcedimientoEliminarHistorialClinico, new
            {
                IdHistorialclinico
            });
        }

        public async Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado)
        {
            return await ListarAsync<HistorialClinicoDto>(NombreProcedimientoListarHistorialClinico, new
            {
                IdGanado
            });
        }
    }
}
