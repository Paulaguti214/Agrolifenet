using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipodereproduccionController : ControllerBase
    {
        private readonly ILogger<TipodereproduccionController> _logger;
        public readonly ITipodereproduccionServicio _tipodeproduccionServicio;
        public TipodereproduccionController(ILogger<TipodereproduccionController> logger, ITipodereproduccionServicio tipodereproduccionServicio)
        {
            _logger = logger;
            _tipodeproduccionServicio = tipodereproduccionServicio;
        }
        [HttpPost("InsertarTipodereproduccion")]
        public async Task AgregarTipodeproduccion(string Tiposdereproduccion, bool EstadoTipodereproduccion)
        {
            await _tipodeproduccionServicio.Agregar(Tiposdereproduccion, EstadoTipodereproduccion);
        }
        [HttpGet("ListarTipodereproduccion")]
        public async Task<IEnumerable<TipodeReproduccion>> ListarTipodereproduccion()
        {
            return await _tipodeproduccionServicio.Listartipodereproduccion();
        }
        [HttpGet("BuscarTipodereproduccion")]
        public async Task<TipodeReproduccion> SeleccionarTipodereproduccion(int IdTipodereproduccion)
        {
            return await _tipodeproduccionServicio.SeleccionarTipodereproduccion(IdTipodereproduccion);
        }
        [HttpDelete("EliminarTipodereproduccion")]
        public async Task EtiminarTipodereproduccion(int IdTipodereproduccion)
        {
            await _tipodeproduccionServicio.EliminarTipodereproduccion(IdTipodereproduccion);
        }
        [HttpPut("ActualizarTiposdereproduccion")]
        public async Task ActualizarTiposdereproduccion(int IdTipodereproduccion, string Tiposdereproduccion, bool EstadoTipodereproduccion)
        {
            await _tipodeproduccionServicio.ActualizarTipodereproduccion(IdTipodereproduccion,Tiposdereproduccion, EstadoTipodereproduccion);
        }



    }
}
