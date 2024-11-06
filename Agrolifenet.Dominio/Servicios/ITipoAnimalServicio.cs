using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipoAnimalServicio
    {
        Task Agregar(string Tiposdeanimal, Boolean estadoTipoanimal);
        Task<IEnumerable<TipoAnimal>> ListarTipoAnimal();
        Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal);
        Task EliminarTipoAnimal(int idTipoanimal);

        Task ActualizarTipoAnimal(int idTipoanimal, string Tiposdeanimal,  Boolean estadoTipoanimal);


    }
}
