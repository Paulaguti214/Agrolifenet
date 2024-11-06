using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Infraestructura.Adaptador;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class TipoAnimalServicio : ITipoAnimalServicio
    {
        private readonly ITipoAnimalRepositorio _tipoAnimalRepositorio;
        public TipoAnimalServicio(ITipoAnimalRepositorio tipoAnimalRepositorio)
        {
            _tipoAnimalRepositorio = tipoAnimalRepositorio;
        }

        public async Task Agregar(string tiposdeanimal, Boolean estadoTipoanimal)
        {
            var fechaActual = DateTime.Now;

            await _tipoAnimalRepositorio.AgregarAsync(tiposdeanimal, fechaActual, fechaActual, estadoTipoanimal);
        }

        public Task<IEnumerable<TipoAnimal>> ListarTipoAnimal()
        {
            return _tipoAnimalRepositorio.ListarTipoAnimal();
        }

        public async Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal)
        {
            return await _tipoAnimalRepositorio.SeleccionarTipoAnimal(idTipoanimal);
        }
    }
    
}
