using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RazaController : ControllerBase
    {
        private readonly IRazaServicio _razaServicio;

        public RazaController(IRazaServicio razaServicio)
        {
            _razaServicio = razaServicio;
        }

        [HttpPost("InsertarRaza")]
        public async Task AgregarRaza(string Tipoderaza, bool EstadoRaza, int IdTipoanimal)
        {
            await _razaServicio.AgregarRaza(Tipoderaza, EstadoRaza, IdTipoanimal);
        }

        [HttpGet("BuscarRaza")]
        public async Task<Raza> SeleccionarRaza(int IdRaza)
        {
            return await _razaServicio.SeleccionarRaza(IdRaza);
        }

        [HttpDelete("EliminarRaza")]
        public async Task EliminarRaza(int IdRaza)
        {
            await _razaServicio.EliminarRaza(IdRaza);
        }

        [HttpPut("ActualizarRaza")]
        public async Task ActualizarRaza(int IdRaza, string Tipoderaza, bool EstadoRaza, int IdTipoanimal)
        {
            await _razaServicio.ActualizarRaza(IdRaza, Tipoderaza, EstadoRaza, IdTipoanimal);
        }
    }
}
