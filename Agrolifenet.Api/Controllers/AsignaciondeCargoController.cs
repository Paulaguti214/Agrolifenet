using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaciondeCargoController : ControllerBase
    {
        private readonly IUsuarioTiposdeCargoServicio _usuarioTiposdeCargoServicio;
        public AsignaciondeCargoController(IUsuarioTiposdeCargoServicio usuarioTiposdeCargoServicio)
        {
            _usuarioTiposdeCargoServicio = usuarioTiposdeCargoServicio;
        }
        [HttpPost("InsertarUsuarioTiposdecargo")]
        public async Task AgregarUsuarioTipodecargo(GuardarUsuarioCargoDto guardarUsuarioCargoDto)
        {
            await _usuarioTiposdeCargoServicio.AgregarUsuarioTiposdeCargoAsync(guardarUsuarioCargoDto.IdUsuario, guardarUsuarioCargoDto.IdTiposdeCargo);
        }
        [HttpDelete("EliminarUsuarioTipodecargo")]
        public async Task EliminarUsuarioTiposdeCargoAsync(int IdUsuarioTiposdecargo)
        {
            await _usuarioTiposdeCargoServicio.EliminarUsuariosTiposdecargoAsync(IdUsuarioTiposdecargo);

        }
        [HttpPut("ActualizarUsuarioTiposdecargo")]
        public async Task ActualizarUsuarioTiposdecargo(ActualizarUsuarioTiposdecargoDto actualizarUsuarioTiposdecargoDto)
        {
            await _usuarioTiposdeCargoServicio.ActualizarUsuarioTiposdeCargoAsync(actualizarUsuarioTiposdecargoDto.IdUsuarioTipodeCargo, actualizarUsuarioTiposdecargoDto.IdUsuario, actualizarUsuarioTiposdecargoDto.IdTiposdeCargo);
        }

        //[HttpGet("BuscarUsuarioTiposdecargo")]
        //public async Task
    }
}
