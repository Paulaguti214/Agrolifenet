using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class DetalleVentaRepositorio : Repositorio<DetalledeVenta>, IDetalleVentaRepositorio
    {
        private readonly string NombreProcedimientoGuardarDetalledeVenta = "InsertarDetalledeventa";
        private readonly string NombreProcedimientoListarDetalledeVenta = "BuscarDetalledeventa";
        private readonly string NombreProcedimientoEliminarDetalledeVenta = "EliminarDetalledeventa";
        private readonly string NombreProcedimientoActualizarDetalledeVenta = "ActualizarDetalledeventa";

        public DetalleVentaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarDetalleVenta(int IdDetalledeventa, DateTime FechademodificacionDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado)
        {
            await ActualizarAsync(NombreProcedimientoActualizarDetalledeVenta, new
            {
                IdDetalledeventa,
                FechademodificacionDetalledeventa,
                EstadoDetalledeventa,
                IdVenta,
                IdGanado
            });
        }

        public async Task AgregarDetalleVenta(DateTime FechadecreacionDetalledeventa, DateTime FechademodificacionDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado)
        {
            await AgregarAsync(NombreProcedimientoGuardarDetalledeVenta, new
            {
                FechadecreacionDetalledeventa,
                FechademodificacionDetalledeventa,
                EstadoDetalledeventa,
                IdVenta,
                IdGanado
            });
        }

        public async Task EliminarDetalleVenta(int IdDetalledeventa)
        {
            await EliminarAsync(NombreProcedimientoEliminarDetalledeVenta, new
            {
                IdDetalledeventa
            });
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta)
        {
            return await ListarAsync<DetalleVentaDto>(NombreProcedimientoListarDetalledeVenta, new
            {
                IdVenta
            });
        }
    }
}
