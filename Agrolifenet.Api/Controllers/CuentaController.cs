using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly IUsurioServicio _usurioServicio;
        public CuentaController(IUsurioServicio usurioServicio)
        {
            _usurioServicio = usurioServicio;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UsuarioTokenDto>> Login([FromBody] LoginDto login)
        {
            return await _usurioServicio.LogeoAsync(login.Usuario, login.Contrasenia);
        }
    }
}
