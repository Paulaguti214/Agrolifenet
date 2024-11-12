using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsurioServicio _usuarioServicio;
        public UsuarioController(ILogger<UsuarioController> logger, IUsurioServicio usuarioServicio)
        {
            _logger = logger;
            _usuarioServicio = usuarioServicio;
        }
        [HttpPost(Name = "insertarUsuario")]
        public async Task InsertarUsuario(int IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario,  bool BloqueoUsuario)
        {

            await _usuarioServicio.Agregar(IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, EstadoUsuario,  BloqueoUsuario);
        }
    }
}
