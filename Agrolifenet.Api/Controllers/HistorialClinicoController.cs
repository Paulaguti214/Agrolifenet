using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialClinicoController : ControllerBase
    {
        private readonly IHistorialClinicoServicio _historialClinicoServicio;

        public HistorialClinicoController(IHistorialClinicoServicio historialClinicoServicio)
        {
            _historialClinicoServicio = historialClinicoServicio;
        }

        [HttpPost("AgregarHistorialClinico")]
        public async Task AgregarHistorialClinico(
            bool estado,
            string vacunas,
            string tratamientos,
            string enfermedades,
            string resultadosExamenes,
            string infoDesparacitacion,
            int pesoAlNacer,
            int pesoActual,
            int gananciaPesoDiaria,
            string observaciones,
            string estadoSalud,
            decimal costoTratamiento,
            string seguimiento,
            int numeroPartos,
            int idGanado,
            int idUsuario,
            int idDatosReproduccion)
        {
            await _historialClinicoServicio.AgregarHistorialClinico(estado, vacunas, tratamientos, enfermedades, resultadosExamenes, infoDesparacitacion, pesoAlNacer, pesoActual, gananciaPesoDiaria, observaciones, estadoSalud, costoTratamiento, seguimiento, numeroPartos, idGanado, idUsuario, idDatosReproduccion);
        }


        [HttpPut("ActualizarHistorialClinico")]
        public async Task ActualizarHistorialClinico(
               int idHistorialClinico,
            bool estado,
            string vacunas,
            string tratamientos,
            string enfermedades,
            string resultadosExamenes,
            string infoDesparacitacion,
            int pesoAlNacer,
            int pesoActual,
            int gananciaPesoDiaria,
            string observaciones,
            string estadoSalud,
            decimal costoTratamiento,
            string seguimiento,
            int numeroPartos,
            int idGanado,
            int idUsuario,
            int idDatosReproduccion)
        {
            await _historialClinicoServicio.ActualizarHistorialClinico(idHistorialClinico, estado, vacunas, tratamientos, enfermedades, resultadosExamenes, infoDesparacitacion, pesoAlNacer, pesoActual, gananciaPesoDiaria, observaciones, estadoSalud, costoTratamiento, seguimiento, numeroPartos, idGanado, idUsuario, idDatosReproduccion);
        }

        [HttpGet("ListarHistorialClinico")]
        public async Task<IEnumerable<HistorialClinicoDto>> ListarHistorialClinico(int IdGanado)
        {
            return await _historialClinicoServicio.ListarHistorialClinico(IdGanado);
        }

        [HttpGet("SeleccionarHistorialClinico")]
        public async Task<HistorialClinicoDto> SeleccionarHistorialClinico(int IdHistorialclinico)
        {
            return await _historialClinicoServicio.SeleccionarHistorialClinico(IdHistorialclinico);
        }

        [HttpDelete("EliminarHistorialClinico")]
        public async Task EliminarHistorialClinico(int IdHistorialclinico)
        {
            await _historialClinicoServicio.EliminarHistorialClinico(IdHistorialclinico);
        }
    }
}
