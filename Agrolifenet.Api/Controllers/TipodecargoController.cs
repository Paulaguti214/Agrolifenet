using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
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
        public async Task AgrgarTipodecargo(GuardarTipodeCargoDto guardarTipodeCargoDto)
        {
            await _tipodecargoServicio.Agregar(guardarTipodeCargoDto.tipodeCargo, guardarTipodeCargoDto.estadoTiposdeCargo);
        }
        [HttpGet("ListarTiposdecargo")]
        public async Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo()
        {
            return await _tipodecargoServicio.ListarTiposdecargo();
        }
        [HttpGet("BuscarTiposdecargo")]
        public async Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo)
        {
            return await _tipodecargoServicio.SeleccionarTiposdecargo(idTiposdecargo);
        }
        [HttpDelete("EliminarTiposdecargo")]
        public async Task EliminarTiposdecargo(int idTiposdecargo)
        {
            await _tipodecargoServicio.EliminarTiposdecargo(idTiposdecargo);
        }
        [HttpPut("ActualizarTiposdecargo")]
        public async Task ActualizarTiposdecargo(ActualizarTiposdeCargoDto actualizarTiposdeCargoDto)
        {
            await _tipodecargoServicio.ActualizarTiposdecargo(actualizarTiposdeCargoDto.idTiposdecargo, actualizarTiposdeCargoDto.tipodeCargo, actualizarTiposdeCargoDto.estadoTiposdeCargo);
        }




    }
}
