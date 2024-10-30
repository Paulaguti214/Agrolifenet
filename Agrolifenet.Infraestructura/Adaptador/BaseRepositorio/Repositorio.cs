using Agrolifenet.Dominio.Puerto.BaseRepositorio;
using Dapper;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador.BaseRepositorio
{
    public class Repositorio<T> : RepositorioLectura<T>, IRepositorio<T> where T : class
    {
        private readonly IDbConnection _baseDeDatos;

        public Repositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
            _baseDeDatos = baseDeDatos;
        }

        public async Task ActualiozarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            await _baseDeDatos.ExecuteAsync(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure);
        }

        public async Task<T> AgregarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            return (await _baseDeDatos.ExecuteScalarAsync<T>(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure))!;
        }

        public async Task EliminarAsync(string nombreProcedimiento, object parametros = default!, CancellationToken cancellationToken = default)
        {
            await _baseDeDatos.ExecuteAsync(nombreProcedimiento, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
