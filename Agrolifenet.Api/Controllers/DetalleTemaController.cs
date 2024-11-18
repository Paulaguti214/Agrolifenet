using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleTemaController : ControllerBase
    {
        private readonly IDetalleTemaServicio _detalleTemaServicio;

        public DetalleTemaController(IDetalleTemaServicio detalleTemaServicio)
        {
            _detalleTemaServicio = detalleTemaServicio;
        }

        [HttpPost("InsertarDetalleTema")]
        public async Task AgregarDetalleTema(bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            await _detalleTemaServicio.AgregarDetalleTema(EstadoDetalledetema, IdTemadeconsulta, EspecificacionDetalledetema);
        }

        [HttpGet("ListarDetalleTema")]
        public async Task<IEnumerable<DetalleTemaDto>> ListarDetalleTema(int IdTemadeconsulta)
        {
            return await _detalleTemaServicio.ListarDetalleTema(IdTemadeconsulta);
        }

        [HttpGet("BuscarDetalledetema")]
        public async Task<DetalleTemaDto> BuscarDetalledetema(int IdDetalledetema)
        {
            return await _detalleTemaServicio.BuscarDetalledetema(IdDetalledetema);
        }

        [HttpDelete("EliminarDetalleTema")]
        public async Task EliminarDetalleTema(int IdDetalledeventa)
        {
            await _detalleTemaServicio.EliminarDetalleTema(IdDetalledeventa);
        }

        [HttpPut("ActualizarDetalleTema")]
        public async Task ActualizarDetalleTema(int IdDetalledeventa, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            await _detalleTemaServicio.ActualizarDetalleTema(IdDetalledeventa, EstadoDetalledetema, IdTemadeconsulta, EspecificacionDetalledetema);
        }
    }
}
