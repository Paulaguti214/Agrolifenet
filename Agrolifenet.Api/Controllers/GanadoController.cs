using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GanadoController : ControllerBase
    {
        private readonly ILogger<GanadoController> _Logger;
        private readonly IGanadoServicio _ganadoServicio;

        public GanadoController(ILogger<GanadoController> logger, IGanadoServicio ganadoServicio)
        {
            _Logger = logger;
            _ganadoServicio = ganadoServicio;
        }

        [HttpPost("InsertarGanado")]
        public async Task AgregarGanado(GuardarGanadoDto guardarGanadoDto)
        {
            await _ganadoServicio.AgregarGanado(guardarGanadoDto.EstadoGanado, guardarGanadoDto.EdadGanado, guardarGanadoDto.SexoGanado, guardarGanadoDto.NumerodelchipGanado, guardarGanadoDto.ColorGanado, guardarGanadoDto.LugardenacimientoGanado, guardarGanadoDto.IdmadreGanado, guardarGanadoDto.IdpadreGanado, guardarGanadoDto.IdRaza, guardarGanadoDto.IdReproduccion, guardarGanadoDto.EstadoNacido, guardarGanadoDto.DescripcionNacimiento, guardarGanadoDto.PesoNacido);
        }

        [HttpGet("BuscarGanado")]
        public async Task<GanadoDto> SeleccionarGanado(int? IdGanado, string? numeroChip)
        {
            return await _ganadoServicio.SeleccionarGanado(IdGanado, numeroChip);
        }

        [HttpGet("ListarGanado")]
        public async Task<IEnumerable<GanadoDto>> ListarGanado()
        {
            return await _ganadoServicio.ListarGanado();
        }

        [HttpDelete("EliminarGanado")]
        public async Task EliminarGanado(int IdGanado)
        {
            await _ganadoServicio.EliminarGanado(IdGanado);
        }

        [HttpPut("ActualizarGanado")]
        public async Task ActualizarGanado(GuardarGanadoDto ganadoDto)
        {
            await _ganadoServicio.ActualizarGanado(ganadoDto.IdGanado, ganadoDto.EstadoGanado, ganadoDto.EdadGanado, ganadoDto.SexoGanado, ganadoDto.NumerodelchipGanado, ganadoDto.ColorGanado, ganadoDto.LugardenacimientoGanado, ganadoDto.IdmadreGanado, ganadoDto.IdpadreGanado, ganadoDto.IdRaza, ganadoDto.IdReproduccion, ganadoDto.EstadoNacido, ganadoDto.DescripcionNacimiento, ganadoDto.PesoNacido);
        }
    }
}
