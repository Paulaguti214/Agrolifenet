using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;

namespace Agrolifenet.Dominio.Puerto
{
    public interface ITipoAnimalRepositorio : IRepositorio<TipoAnimal>
    {
        Task AgregarAsync(string tipoAnimal);
    }
}
