using static Agrolifenet.Dominio.Puerto.BaseRepositorio.IRepositorioLectura;

namespace Agrolifenet.Dominio.Puerto.BaseRepositorio
{
    public interface IRepositorio<T> : IRepositorioLectura<T> where T : class
    {
        Task<T> AgregarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);


        Task ActualiozarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);

        Task EliminarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);

    }
}
