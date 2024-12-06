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
    }
}
