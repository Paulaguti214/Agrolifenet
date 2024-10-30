using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class TipoAnimalServicio : ITipoAnimalServicio
    {
        private readonly ITipoAnimalRepositorio _tipoAnimalRepositorio;
        public TipoAnimalServicio(ITipoAnimalRepositorio tipoAnimalRepositorio)
        {
            _tipoAnimalRepositorio = tipoAnimalRepositorio;
        }

        public async Task Agregar(string tipoAnimal)
        {
            await _tipoAnimalRepositorio.AgregarAsync(tipoAnimal);
        }
    }
}
