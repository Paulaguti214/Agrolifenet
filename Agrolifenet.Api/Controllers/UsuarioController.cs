using Agrolifenet.Dominio.Dto;
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
        [HttpPost("insertarUsuario")]
        public async Task InsertarUsuario(UsuarioDto usuario)
        {
            await _usuarioServicio.Agregar(usuario);
        }
        [HttpGet("ListarUsuario")]
        public async Task<IEnumerable<Usuario>> ListarUsuario()
        {

            return await _usuarioServicio.ListarUsuario();
        }

        [HttpGet("SeleccionarUsuario")]
        public async Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo)
        {

            return await _usuarioServicio.SeleccionarUsuario(identificacionUsuario, tipodecargo);
        }
        [HttpDelete("EliminarUsuario")]
        public async Task EliminarUsuario(int idUsuario)
        {

            await _usuarioServicio.EliminarUsuario(idUsuario);
        }
        [HttpPut("ActualizarUsuario")]
        public async Task ActualizarTipoanimal(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario, bool BloqueoUsuario)
        {

            await _usuarioServicio.ActualizarUsuario(idUsuario, IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, EstadoUsuario, BloqueoUsuario);
        }


    }
}

