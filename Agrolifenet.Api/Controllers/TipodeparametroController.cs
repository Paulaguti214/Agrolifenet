using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipodeparametroController : ControllerBase
    {
        private readonly ILogger<TipodeparametroController> _logger;
        private readonly ITipodeparametroServicio _tipodeparametroServicio;
        public TipodeparametroController(ILogger<TipodeparametroController> logger, ITipodeparametroServicio tipodeparametroServicio )
        {
            _logger = logger;
            _tipodeparametroServicio = tipodeparametroServicio;
        }
        [HttpPost("InsertarTipodeparametro")]
        public async Task AgregarTipodeparametro(string Tiposdeparametros, bool EstadoTipodeparametro)
        {
            await _tipodeparametroServicio.Agregar(Tiposdeparametros, EstadoTipodeparametro);
        }

        [HttpGet("ListarTipodeparametro")]
        public async Task<IEnumerable<TipodeParametro>> ListarTipodeparametro()
        {
            return await _tipodeparametroServicio.ListarTipodeparametro();
        }
        [HttpGet("BuscarTipodeparametro")]
        public async Task<TipodeParametro> SeleccionarTipodeparametro(int IdTipodeparametro)
        {
            return await _tipodeparametroServicio.SeleccionarTipodeparametro(IdTipodeparametro);
        }
        [HttpDelete("EliminarTipodeparametro")]
        public async Task EliminarTipodeparametro(int IdTipodeparametro)
        {
            await _tipodeparametroServicio.EliminarTipodeparametro(IdTipodeparametro);
        }
        [HttpPut("ActualizarTipodeparametro")]
        public async Task ActualizarTipodeparametro(int IdTipodeparametro, string Tiposdeparametros, bool EstadoTipodeparametro)
        {
            await _tipodeparametroServicio.ActualizarTipodeparametro(IdTipodeparametro, Tiposdeparametros, EstadoTipodeparametro);
        }
    }
}
