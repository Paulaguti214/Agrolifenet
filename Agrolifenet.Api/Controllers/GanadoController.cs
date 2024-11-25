using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
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
            await _ganadoServicio.AgregarGanado(guardarGanadoDto.EstadoGanado, guardarGanadoDto.EdadGanado, guardarGanadoDto.SexoGanado, guardarGanadoDto.NumerodelchipGanado, guardarGanadoDto.ColorGanado, guardarGanadoDto.LugardenacimientoGanado, guardarGanadoDto.IdmadreGanado, guardarGanadoDto.IdpadreGanado, guardarGanadoDto.IdRaza);
        }

        [HttpGet("BuscarGanado")]
        public async Task<Ganado> SeleccionarGanado(int IdGanado)
        {
            return await _ganadoServicio.SeleccionarGanado(IdGanado);
        }

        [HttpGet("ListarGanado")]
        public async Task<IEnumerable<ListarGanadoDto>> ListarGanado()
        {
            return await _ganadoServicio.ListarGanado();
        }

        [HttpDelete("EliminarGanado")]
        public async Task EliminarGanado(int IdGanado)
        {
            await _ganadoServicio.EliminarGanado(IdGanado);
        }

        [HttpPut("ActualizarGanado")]
        public async Task ActualizarGanado(int IdGanado, bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza)
        {
            await _ganadoServicio.ActualizarGanado(IdGanado, EstadoGanado, EdadGanado, sexoGanado, NumeridechipGanado, ColorGanado, LugardenacimientoGanado, IdMadreGanado, IdPadreGanado, IdRaza);
        }
    }
}
