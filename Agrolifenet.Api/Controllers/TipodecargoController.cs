using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class TipodecargoController : ControllerBase
    {
        private readonly ILogger<TipodecargoController> _logger;
        private readonly ITipodecargoServicio _tipodecargoServicio; 

        public TipodecargoController(ILogger<TipodecargoController> logger, ITipodecargoServicio tipodecargoServicio)
        {
            _logger = logger;
            _tipodecargoServicio = tipodecargoServicio;
        }
        [HttpPost("InsertarTiposdecargo")] 
        public async Task AgrgarTipodecargo(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo, bool estadoTiposdecargo)
        {
            await _tipodecargoServicio.Agregar(tipodecargo, fechadecreacionTiposdecargo, fechademodificacionTiposdecargo, estadoTiposdecargo);
        }
    }
}
