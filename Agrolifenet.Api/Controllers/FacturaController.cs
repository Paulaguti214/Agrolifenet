using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaServicio _facturaServicio;
        public FacturaController(IFacturaServicio facturaServicio)
        {
            _facturaServicio = facturaServicio;
        }

        [HttpGet("GenerarFactura")]
        public async Task<IActionResult> CreatePdf(Guid consecutivoFactura)
        {
            var archivo = await _facturaServicio.GenerarFacturaAsync(consecutivoFactura);
            return File(archivo, "application/octet-stream", $"{consecutivoFactura}.pdf");
        }

        [HttpGet("VerFacturas")]
        public async Task<IEnumerable<Ventas>> VerFacturas()
        {
            return await _facturaServicio.VerFacturaAsync();
        }
    }
}
