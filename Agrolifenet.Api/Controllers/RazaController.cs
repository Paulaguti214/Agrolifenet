using Agrolifenet.Dominio.Dto;
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
        public async Task AgregarRaza(GuardarRazaDto guardarRazaDto)
        {
            await _razaServicio.AgregarRaza(guardarRazaDto.Tipoderaza, guardarRazaDto.EstadoRaza, guardarRazaDto.IdTipoanimal);
        }

        [HttpGet("BuscarRaza")]
        public async Task<RazaTipoAnimalDto> SeleccionarRaza(int IdRaza)
        {
            return await _razaServicio.SeleccionarRaza(IdRaza);
        }

        [HttpDelete("EliminarRaza")]
        public async Task EliminarRaza(int IdRaza)
        {
            await _razaServicio.EliminarRaza(IdRaza);
        }

        [HttpPut("ActualizarRaza")]
        public async Task ActualizarRaza(ActualizarRazaDto actualizarRazaDto)
        {
            await _razaServicio.ActualizarRaza(actualizarRazaDto.IdRaza, actualizarRazaDto.Tipoderaza, actualizarRazaDto.EstadoRaza, actualizarRazaDto.IdTipoanimal);
        }
        [HttpGet("LisatarRaza")]
        public async Task<IEnumerable<ListarRazaDto>> ListarRaza()
        {
            return await _razaServicio.ListarRaza();
        }
    }
}
