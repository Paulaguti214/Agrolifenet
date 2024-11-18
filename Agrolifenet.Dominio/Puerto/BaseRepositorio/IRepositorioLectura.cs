namespace Agrolifenet.Dominio.Puerto.BaseRepositorio
{
    public interface IRepositorioLectura
    {
        public interface IRepositorioLectura<T> where T : class
        {
            Task<T> SeleccionarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<TDto> SeleccionarAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<IEnumerable<T>> ListarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<IEnumerable<TDto>> ListarAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
        }
    }
}
