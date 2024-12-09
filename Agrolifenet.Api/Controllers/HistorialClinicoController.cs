using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
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
        public async Task AgregarHistorialClinico(GuardarHistorialClinico guardarHistorialClinico)
        {
            await _historialClinicoServicio.AgregarHistorialClinico(guardarHistorialClinico);
        }


        [HttpPut("ActualizarHistorialClinico")]
        public async Task ActualizarHistorialClinico(GuardarHistorialClinico guardarHistorialClinico)
        {
            await _historialClinicoServicio.ActualizarHistorialClinico(guardarHistorialClinico);
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

        [HttpGet("ListarHistorialClinicoGeneral")]
        public async Task<IEnumerable<HistorialClinico>> ListarHistorialClinicoGeneral()
        {
            return await _historialClinicoServicio.ListarHistorialClinicoGeneral();
        }
    }
}
