namespace Agrolifenet.Dominio.Puerto.BaseRepositorio
{
    public interface IRepositorioLectura
    {
        public interface IRepositorioLectura<T> where T : class
        {
            Task<T> SeleccionarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<TDto> SeleccionarAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<IEnumerable<T>> ListAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
            Task<IEnumerable<TDto>> ListAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default);
        }
    }
}
