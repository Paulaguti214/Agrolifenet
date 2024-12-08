using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {
        private readonly IDetalleVentaServicio _detalleVentaServicio;

        public DetalleVentaController(IDetalleVentaServicio detalleVentaServicio)
        {
            _detalleVentaServicio = detalleVentaServicio;
        }

        [HttpPost("InsertarDetalleVenta")]
        public async Task AgregarDetalleVenta(DetalleVentaDto detalleVenta)
        {
            await _detalleVentaServicio.AgregarDetalleVenta(detalleVenta);
        }

        [HttpPost("InsertarVariosDetalleVenta")]
        public async Task AgregarDetalleVenta(IEnumerable<DetalleVentaDto> detalleVentas)
        {
            await _detalleVentaServicio.AgregarVariosDetalleVenta(detalleVentas);
        }

        [HttpGet("ListarDetalleVenta")]
        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta)
        {
            return await _detalleVentaServicio.ListarDetalleVenta(IdVenta);
        }

        [HttpDelete("EliminarDetalleVenta")]
        public async Task EliminarDetalleVenta(int IdDetalledeventa)
        {
            await _detalleVentaServicio.EliminarDetalleVenta(IdDetalledeventa);
        }

        [HttpPut("ActualizarDetalleVenta")]
        public async Task ActualizarDetalleVenta(int IdDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado)
        {
            await _detalleVentaServicio.ActualizarDetalleVenta(IdDetalledeventa, EstadoDetalledeventa, IdVenta, IdGanado);
        }
    }
}
