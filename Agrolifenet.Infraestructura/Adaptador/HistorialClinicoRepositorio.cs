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
        private readonly string NombreProcedimientoListarHistorialClinicoGeneral = "ListarHistorialclinicoGeneral";

        public HistorialClinicoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarHistorialClinico(HistorialClinico historialClinico)
        {
            await ActualizarAsync(NombreProcedimientoActualizarHistorialClinico, new
            {
                historialClinico.IdHistorialClinico,
                historialClinico.FechadecreacionHistorialClinico,
                historialClinico.FechademodificacionHistorialClinico,
                historialClinico.EstadoHistorialClinico,
                historialClinico.VacunaHistorialClinico,
                historialClinico.TratamientoHistorialClinico,
                historialClinico.EnfermedadesHistorialClinico,
                historialClinico.ResultadodeExamenesHistorialClinico,
                historialClinico.InformaciondesparacitacionHistorialClinico,
                historialClinico.PesoalnacerHistorialClinico,
                historialClinico.PesoactualHistorialClinico,
                historialClinico.GananciadepesodiariaHistorialClinico,
                historialClinico.ObservacionesHistorialClinico,
                historialClinico.EstadodesaludHistorialClinico,
                historialClinico.CostodeltratamientoHistorialClinico,
                historialClinico.SeguimientoHistorialClinico,
                historialClinico.NumerodepartosHistorialClinico,
                historialClinico.IdGanado,
                historialClinico.IdUsuario,
                historialClinico.Enfermo
            });
        }

        public async Task AgregarHistorialClinico(HistorialClinico historialClinico)
        {
            await AgregarAsync(NombreProcedimientoGuardarHistorialClinico, new
            {
                historialClinico.FechadecreacionHistorialClinico,
                historialClinico.FechademodificacionHistorialClinico,
                historialClinico.EstadoHistorialClinico,
                historialClinico.VacunaHistorialClinico,
                historialClinico.TratamientoHistorialClinico,
                historialClinico.EnfermedadesHistorialClinico,
                historialClinico.ResultadodeExamenesHistorialClinico,
                historialClinico.InformaciondesparacitacionHistorialClinico,
                historialClinico.PesoalnacerHistorialClinico,
                historialClinico.PesoactualHistorialClinico,
                historialClinico.GananciadepesodiariaHistorialClinico,
                historialClinico.ObservacionesHistorialClinico,
                historialClinico.EstadodesaludHistorialClinico,
                historialClinico.CostodeltratamientoHistorialClinico,
                historialClinico.SeguimientoHistorialClinico,
                historialClinico.NumerodepartosHistorialClinico,
                historialClinico.IdGanado,
                historialClinico.IdUsuario,
                historialClinico.Enfermo
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

        public async Task<IEnumerable<HistorialClinico>> ListarHistorialClinicoGeneral()
        {
            return await ListarAsync(NombreProcedimientoListarHistorialClinicoGeneral);
        }
    }
}
