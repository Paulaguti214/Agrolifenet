using Dapper;
using System.Data;
using static Agrolifenet.Dominio.Puerto.BaseRepositorio.IRepositorioLectura;

namespace Agrolifenet.Infraestructura.Adaptador.BaseRepositorio
{
    public class RepositorioLectura<T> : IRepositorioLectura<T> where T : class
    {
        private readonly IDbConnection _baseDeDatos;

        public RepositorioLectura(IDbConnection baseDeDatos)
        {
            _baseDeDatos = baseDeDatos;
        }

        public async Task<IEnumerable<T>> ListarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            return await _baseDeDatos.QueryAsync<T>(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<TDto>> ListarAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            return await _baseDeDatos.QueryAsync<TDto>(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure);
        }

        public async Task<T> SeleccionarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            return (await _baseDeDatos.QueryFirstOrDefaultAsync<T>(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure))!;
        }

        public async Task<TDto> SeleccionarAsync<TDto>(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            return (await _baseDeDatos.QueryFirstOrDefaultAsync<TDto>(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure))!;
        }
    }
}
