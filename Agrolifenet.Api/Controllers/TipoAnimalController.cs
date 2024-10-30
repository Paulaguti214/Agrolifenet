using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoAnimalController : ControllerBase
    {
        private readonly ILogger<TipoAnimalController> _logger;
        private readonly ITipoAnimalServicio _tipoAnimalServicio;

        public TipoAnimalController(ILogger<TipoAnimalController> logger, ITipoAnimalServicio tipoAnimalServicio)
        {
            _logger = logger;
            _tipoAnimalServicio = tipoAnimalServicio;
        }

        [HttpGet(Name = "AgregarTipoAnimal")]
        public async Task AgregarTipoAnimal(string tipoAnimal)
        {
            await _tipoAnimalServicio.Agregar(tipoAnimal);
        }
    }
}
