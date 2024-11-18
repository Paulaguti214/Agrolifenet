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
        private readonly string NombreProcedimientoEliminarTipoAnimal = "EliminarTipoanimal";
        private readonly string NombreProcedimientoActualizarTipoAnimal = "ActualizarTipoanimal";

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
            return await ListarAsync(NombreProcedimientoListarTipoAnimal);
        }

        public async Task<TipoAnimal> SeleccionarTipoAnimal(int idTipoanimal)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarTipoAnimal, new
            {
                idTipoanimal
            });
        }
        public async Task EliminarTipoAnimal(int idTipoanimal)
        {
            await EliminarAsync(NombreProcedimientoEliminarTipoAnimal, new
            {
                idTipoanimal
            });
        }

        public async Task ActualizarTipoAnimal(int idTipoanimal, string tiposdeanimal, DateTime fechademodificacionTipoanimal,
            Boolean estadoTipoanimal)
        {
            await ActualizarAsync(NombreProcedimientoActualizarTipoAnimal, new
            {
                idTipoanimal,
                tiposdeanimal,
                fechademodificacionTipoanimal,
                estadoTipoanimal
            });
        }
    }
}
