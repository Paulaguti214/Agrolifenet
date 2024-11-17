using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaServicio _ventaServicio;

        public VentaController(IVentaServicio ventaServicio)
        {
            _ventaServicio = ventaServicio;
        }

        [HttpPost("InsertarVenta")]
        public async Task AgregarVenta(bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            await _ventaServicio.AgregarVenta(EstadoVenta, FechadelaVenta, NombredelcompradorVenta,
             IdentificaciondelcompradorVentas, Telefonodelcomprador, PrecioVenta, MetododepagoVenta, DestinoVenta, CondicionesdeVenta,
             EstadodelanimalenVenta, ObservacionesVenta, IdUsuario);
        }

        [HttpGet("BuscarVenta")]
        public async Task<VentaDto> SeleccionarVenta(int IdVenta)
        {
            return await _ventaServicio.SeleccionarVenta(IdVenta);
        }

        [HttpDelete("EliminarVenta")]
        public async Task EliminarVenta(int IdVenta)
        {
            await _ventaServicio.EliminarVenta(IdVenta);
        }

        [HttpPut("ActualizarVenta")]
        public async Task ActualizarVenta(int IdVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            await _ventaServicio.ActualizarVenta(IdVenta, EstadoVenta, FechadelaVenta, NombredelcompradorVenta,
             IdentificaciondelcompradorVentas, Telefonodelcomprador, PrecioVenta, MetododepagoVenta, DestinoVenta, CondicionesdeVenta,
             EstadodelanimalenVenta, ObservacionesVenta, IdUsuario);
        }
    }
}
