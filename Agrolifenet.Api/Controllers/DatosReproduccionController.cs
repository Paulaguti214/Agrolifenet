using Agrolifenet.Dominio.Dto;
using Agrolifenet.Infraestructura.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosReproduccionController : ControllerBase
    {
        private readonly IDatosdeReproduccionServicio _datosdeReproduccionServicio;

        public DatosReproduccionController(IDatosdeReproduccionServicio datosdeReproduccionServicio)
        {
            _datosdeReproduccionServicio = datosdeReproduccionServicio;
        }

        [HttpPost("AgregarDatosReproduccion")]
        public async Task AgregarDatosReproduccion(int IdRepruductor, bool Resultadodelareproduccion, string ObservacionesDatosdereproduccion, bool EstadoDatosdereproduccion, DateTime Fechadelprocesodereproduccion, int IdTipodereproduccion)
        {
            await _datosdeReproduccionServicio.AgregarDatosdeReproduccion(IdRepruductor, Resultadodelareproduccion, ObservacionesDatosdereproduccion, EstadoDatosdereproduccion, Fechadelprocesodereproduccion, IdTipodereproduccion);
        }

        [HttpGet("ListarDatosdeReproduccion")]
        public async Task<IEnumerable<DatosReproduccionDto>> ListarDetalleTema(int IdGanado)
        {
            return await _datosdeReproduccionServicio.ListarDatosdeReproduccion(IdGanado);
        }

        [HttpGet("BuscarDatosdeReproduccion")]
        public async Task<DatosReproduccionDto> BuscarDatosdeReproduccion(int IdDatosdereproduccion)
        {
            return await _datosdeReproduccionServicio.BuscarDatosdeReproduccion(IdDatosdereproduccion);
        }

        [HttpDelete("EliminarDatosReproduccion")]
        public async Task EliminarDatosReproduccion(int IdDatosdereproduccion)
        {
            await _datosdeReproduccionServicio.EliminarDatosdeReproduccion(IdDatosdereproduccion);
        }

        [HttpPut("ActualizarDatosReproduccion")]
        public async Task ActualizarDatosReproduccion(int IdDatosdereproduccion,
            int IdRepruductorDatosdereproduccion,
            bool Resultadodelareproduccion,
            string ObservacionesDatosdereproduccion,
            bool EstadoDatosdereproduccion,
            DateTime Fechadelprocesodereproduccion,
            int IdTipodereproduccion)
        {
            await _datosdeReproduccionServicio.ActualizarDatosdeReproduccion(IdDatosdereproduccion, IdRepruductorDatosdereproduccion, Resultadodelareproduccion, ObservacionesDatosdereproduccion, EstadoDatosdereproduccion, Fechadelprocesodereproduccion, IdTipodereproduccion);
        }
    }
}
