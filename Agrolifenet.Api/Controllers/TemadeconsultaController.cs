using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemadeconsultaController : ControllerBase
    {
        private readonly ILogger<TemadeconsultaController> _logger;
        private readonly ITemadeconsultaServicio _temadeconsultaServicio;
        public TemadeconsultaController(ILogger<TemadeconsultaController> logger, ITemadeconsultaServicio temadeconsultaServicio)
        {
            _logger = logger;
            _temadeconsultaServicio = temadeconsultaServicio;
        }
        [HttpPost("InsertarTemadeconsulta")]
        public async Task AgregarTemadeconsulta(bool EstadoTemadeconsulta, string Temasdeconsulta)
        {
            await _temadeconsultaServicio.AgregarTemadeconsulta(EstadoTemadeconsulta, Temasdeconsulta);
        }

        [HttpGet("ListarTemadeconsulta")]
        public async Task<IEnumerable<TemadeConsulta>> ListarTemadeconsulta()
        {

            return await _temadeconsultaServicio.ListarTemadeconsulta();
        }

        [HttpGet("BuscarTemadeconsulta")]
        public async Task<TemadeConsulta> SeleccionarTemadeconsulta(int IdTemadeconsulta)
        {

            return await _temadeconsultaServicio.SeleccionTemadeconsulta(IdTemadeconsulta);
        }
        [HttpDelete("EliminarTemadeconsulta")]
        public async Task EliminarTemadeconsulta(int IdTemadeconsulta)
        {

            await _temadeconsultaServicio.EliminarTemadeconsulta(IdTemadeconsulta);
        }
        [HttpPut("ActualizarTemadeconsulta")]
        public async Task ActualizarTemadeconsulta(int IdTemadeconsulta, bool EstadoTemadeconsulta, string Temasdeconsulta)
        {

            await _temadeconsultaServicio.ActualizarTemadeconsulta(IdTemadeconsulta, EstadoTemadeconsulta, Temasdeconsulta);
        }
    }
}
