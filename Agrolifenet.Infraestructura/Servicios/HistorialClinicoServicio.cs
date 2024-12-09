using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class HistorialClinicoServicio : IHistorialClinicoServicio
    {
        private readonly IHistorialClinicoRepositorio _historialClinicoRepositorio;

        public HistorialClinicoServicio(IHistorialClinicoRepositorio historialClinicoRepositorio)
        {
            _historialClinicoRepositorio = historialClinicoRepositorio;
        }

        public async Task ActualizarHistorialClinico(GuardarHistorialClinico actuializarHistorialClinico)
        {
            var fechaActual = DateTime.Now;
            var historialClinico = new HistorialClinico
            {
                IdHistorialClinico = actuializarHistorialClinico.IdHistorialClinico,
                FechadecreacionHistorialClinico = fechaActual,
                FechademodificacionHistorialClinico = fechaActual,
                EstadoHistorialClinico = actuializarHistorialClinico.EstadoHistorialClinico,
                VacunaHistorialClinico = actuializarHistorialClinico.VacunaHistorialClinico,
                TratamientoHistorialClinico = actuializarHistorialClinico.TratamientoHistorialClinico,
                EnfermedadesHistorialClinico = actuializarHistorialClinico.EnfermedadesHistorialClinico,
                ResultadodeExamenesHistorialClinico = actuializarHistorialClinico.ResultadodeExamenesHistorialClinico,
                InformaciondesparacitacionHistorialClinico = actuializarHistorialClinico.InformaciondesparacitacionHistorialClinico,
                PesoalnacerHistorialClinico = actuializarHistorialClinico.PesoalnacerHistorialClinico,
                PesoactualHistorialClinico = actuializarHistorialClinico.PesoactualHistorialClinico,
                GananciadepesodiariaHistorialClinico = actuializarHistorialClinico.GananciadepesodiariaHistorialClinico,
                ObservacionesHistorialClinico = actuializarHistorialClinico.ObservacionesHistorialClinico,
                EstadodesaludHistorialClinico = actuializarHistorialClinico.EstadodesaludHistorialClinico,
                CostodeltratamientoHistorialClinico = actuializarHistorialClinico.CostodeltratamientoHistorialClinico,
                SeguimientoHistorialClinico = actuializarHistorialClinico.SeguimientoHistorialClinico,
                NumerodepartosHistorialClinico = actuializarHistorialClinico.NumerodepartosHistorialClinico,
                IdGanado = actuializarHistorialClinico.IdGanado,
                IdUsuario = actuializarHistorialClinico.IdUsuario,
                Enfermo = actuializarHistorialClinico.Enfermo,
            };

            await _historialClinicoRepositorio.ActualizarHistorialClinico(historialClinico);
        }

        public async Task AgregarHistorialClinico(GuardarHistorialClinico actuializarHistorialClinico)
        {
            var fechaActual = DateTime.Now;
            var historialClinico = new HistorialClinico
            {
                FechadecreacionHistorialClinico = fechaActual,
                FechademodificacionHistorialClinico = fechaActual,
                EstadoHistorialClinico = actuializarHistorialClinico.EstadoHistorialClinico,
                VacunaHistorialClinico = actuializarHistorialClinico.VacunaHistorialClinico,
                TratamientoHistorialClinico = actuializarHistorialClinico.TratamientoHistorialClinico,
                EnfermedadesHistorialClinico = actuializarHistorialClinico.EnfermedadesHistorialClinico,
                ResultadodeExamenesHistorialClinico = actuializarHistorialClinico.ResultadodeExamenesHistorialClinico,
                InformaciondesparacitacionHistorialClinico = actuializarHistorialClinico.InformaciondesparacitacionHistorialClinico,
                PesoalnacerHistorialClinico = actuializarHistorialClinico.PesoalnacerHistorialClinico,
                PesoactualHistorialClinico = actuializarHistorialClinico.PesoactualHistorialClinico,
                GananciadepesodiariaHistorialClinico = actuializarHistorialClinico.GananciadepesodiariaHistorialClinico,
                ObservacionesHistorialClinico = actuializarHistorialClinico.ObservacionesHistorialClinico,
                EstadodesaludHistorialClinico = actuializarHistorialClinico.EstadodesaludHistorialClinico,
                CostodeltratamientoHistorialClinico = actuializarHistorialClinico.CostodeltratamientoHistorialClinico,
                SeguimientoHistorialClinico = actuializarHistorialClinico.SeguimientoHistorialClinico,
                NumerodepartosHistorialClinico = actuializarHistorialClinico.NumerodepartosHistorialClinico,
                IdGanado = actuializarHistorialClinico.IdGanado,
                IdUsuario = actuializarHistorialClinico.IdUsuario,
                Enfermo = actuializarHistorialClinico.Enfermo,
            };
            await _historialClinicoRepositorio.AgregarHistorialClinico(historialClinico);
        }

        public async Task EliminarHistorialClinico(int IdHistorialclinico)
        {
            await _historialClinicoRepositorio.EliminarHistorialClinico(IdHistorialclinico);
        }

        public async Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado)
        {
            return await _historialClinicoRepositorio.ListarHistorialClinico(IdGanado);
        }

        public async Task<IEnumerable<HistorialClinico>> ListarHistorialClinicoGeneral()
        {
            return await _historialClinicoRepositorio.ListarHistorialClinicoGeneral();
        }

        public async Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico)
        {
            return await _historialClinicoRepositorio.SeleccionarHistorialClinico(IdHistorialclinico);
        }
    }
}
