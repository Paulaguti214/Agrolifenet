using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class RazaRepositorio : Repositorio<Raza>, IRazaRepositorio
    {
        private readonly string NombreProcedimientoGuardarRaza = "InsertarRaza";
        private readonly string NombreProcedimientoSeleccionarRaza = "BuscarRaza";
        private readonly string NombreProcedimientoEliminarRaza = "EliminarRaza";
        private readonly string NombreProcedimientoActualizarRaza = "ActualizarRaza";
        private readonly string NombreProcedimientoListarRaza = "LisatarRaza";

        public RazaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarRaza(int IdRaza, string Tipoderaza, DateTime FechademodificacionRaza, bool EstadoRaza, int IdTipoanimal)
        {
            await ActualizarAsync(NombreProcedimientoActualizarRaza, new
            {
                IdRaza,
                Tipoderaza,
                FechademodificacionRaza,
                EstadoRaza,
                IdTipoanimal
            });
        }

        public async Task AgregarRaza(string Tipoderaza, DateTime FechadecreacionRaza, DateTime FechademodificacionRaza, bool EstadoRaza, int IdTipoanimal)
        {
            await AgregarAsync(NombreProcedimientoGuardarRaza, new
            {
                Tipoderaza,
                FechadecreacionRaza,
                FechademodificacionRaza,
                EstadoRaza,
                IdTipoanimal
            });
        }

        public async Task EliminarRaza(int IdRaza)
        {
            await EliminarAsync(NombreProcedimientoEliminarRaza, new
            {
                IdRaza
            });
        }

        public async Task<IEnumerable<Raza>> ListarRaza()
        {
            return await ListarAsync(NombreProcedimientoListarRaza);
        }

        public async Task<RazaTipoAnimalDto> SeleccionarRaza(int IdRaza)
        {
            return await SeleccionarAsync<RazaTipoAnimalDto>(NombreProcedimientoSeleccionarRaza, new
            {
                IdRaza
            });
        }
    }
}
