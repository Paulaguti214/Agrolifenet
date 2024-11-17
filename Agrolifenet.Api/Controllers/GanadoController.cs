using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Http;
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
        public async Task AgregarGanado(bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza)
        {
            await _ganadoServicio.AgregarGanado(EstadoGanado, EdadGanado, sexoGanado, NumeridechipGanado, ColorGanado, LugardenacimientoGanado, IdMadreGanado, IdPadreGanado, IdRaza);
        }

        [HttpGet("BuscarGanado")]
        public async Task<Ganado> SeleccionarGanado(int IdGanado)
        {

            return await _ganadoServicio.SeleccionarGanado( IdGanado);
        }
        [HttpDelete("EliminarGanado")]
        public async Task EliminarGanado(int IdGanado)
        {

            await _ganadoServicio.EliminarGanado( IdGanado);
        }
        [HttpPut("ActualizarGanado")]
        public async Task ActualizarGanado(int IdGanado, bool EstadoGanado, int EdadGanado, string sexoGanado, string NumeridechipGanado, string ColorGanado, string LugardenacimientoGanado, int IdMadreGanado, int IdPadreGanado, int IdRaza)
        {

            await _ganadoServicio.ActualizarGanado(IdGanado,EstadoGanado, EdadGanado, sexoGanado, NumeridechipGanado, ColorGanado, LugardenacimientoGanado, IdMadreGanado, IdPadreGanado, IdRaza);
        }
    }
}
