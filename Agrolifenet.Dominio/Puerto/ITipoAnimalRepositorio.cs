using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;

namespace Agrolifenet.Dominio.Puerto
{
    public interface ITipoAnimalRepositorio : IRepositorio<TipoAnimal>
    {
        Task AgregarAsync(string tiposdeanimal, DateTime fechadecreacionTipoanimal, DateTime fechademodificacionTipoanimal,
            Boolean estadoTipoanimal);

        Task<IEnumerable<TipoAnimal>> ListarTipoAnimal();
        Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal);

        Task  EliminarTipoAnimal(int idTipoanimal);

        Task ActualizarTipoAnimal(int idTipoanimal, string tiposdeanimal, DateTime fechademodificacionTipoanimal,
            Boolean estadoTipoanimal);

    }
}
