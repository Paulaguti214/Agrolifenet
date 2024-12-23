using Agrolifenet.Dominio.Entidades;
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

        [HttpPost(Name = "AgregarTipoAnimal")]
        public async Task AgregarTipoAnimal(string Tiposdeanimal, Boolean estadoTipoanimal)
        {

            await _tipoAnimalServicio.Agregar(Tiposdeanimal, estadoTipoanimal);
        }

        //[HttpGet(Name = "ListarTipoAnimal")]
        //public async Task<IEnumerable<TipoAnimal>> ListarTipoAnimal()
        //{

        //    return await _tipoAnimalServicio.ListarTipoAnimal();
        //}

        [HttpGet(Name = "SeleccionarTipoAnimal")]
        public async Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal)
        {

            return await _tipoAnimalServicio.SeleccionarTipoAnimal(idTipoanimal);
        }
        [HttpDelete(Name = "EliminarTipoAnimal")]
        public async Task EliminarTipoAnimal(int idTipoanimal)
        {

            await _tipoAnimalServicio.EliminarTipoAnimal(idTipoanimal);
        }
        [HttpPut(Name = "ActualizarTipoanimal")]
        public async Task ActualizarTipoanimal(int idTipoanimal, string tiposdeanimal,   Boolean estadoTipoanimal)
        {

            await _tipoAnimalServicio.ActualizarTipoAnimal(idTipoanimal, tiposdeanimal,  estadoTipoanimal);
        }


    }
}
