using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipoAnimalRepositorio : Repositorio<TipoAnimal>, ITipoAnimalRepositorio
    {
        private readonly string NombreProcedimientoGuardar = "InsertarTipoanimal";
        private readonly string NombreProcedimientoListarTipoAnimal = "ListarTipoanimal";
        private readonly string NombreProcedimientoSeleccionarTipoAnimal = "BuscarTipoanimal";

        public TipoAnimalRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }


        public async Task AgregarAsync(string tiposdeanimal, DateTime fechadecreacionTipoanimal, DateTime fechademodificacionTipoanimal, bool estadoTipoanimal)
        {

            await AgregarAsync(NombreProcedimientoGuardar, new
            {
                tiposdeanimal,
                fechadecreacionTipoanimal,
                fechademodificacionTipoanimal,
                estadoTipoanimal
            }); ;
        }

        public async Task<IEnumerable<TipoAnimal>> ListarTipoAnimal()
        {
            return await ListAsync(NombreProcedimientoListarTipoAnimal);
        }

        public async Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTipoAnimal, new
            {
                idTipoanimal
            });
        }
    }
}
