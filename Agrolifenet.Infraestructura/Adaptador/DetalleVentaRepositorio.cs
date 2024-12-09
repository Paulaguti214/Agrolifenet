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
        private readonly string NombreProcedimientoBuscarDetalledeVenta = "BuscarDetalledeventa";
        private readonly string NombreProcedimientoEliminarDetalledeVenta = "EliminarDetalledeventa";
        private readonly string NombreProcedimientoActualizarDetalledeVenta = "ActualizarDetalledeventa";
        private readonly string NombreProcedimientoListarDetalledeVenta = "ListarDetalleVenta";

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

        public async Task AgregarDetalleVenta(DetalledeVenta detalledeVenta)
        {
            await AgregarAsync(NombreProcedimientoGuardarDetalledeVenta, new
            {
                detalledeVenta.FechadecreacionDetalledeVenta,
                detalledeVenta.FechademodificacionDetalledeVenta,
                detalledeVenta.EstadoDetalledeVenta,
                detalledeVenta.IdVenta,
                detalledeVenta.IdGanado,
                detalledeVenta.Valor
            });
        }

        public async Task EliminarDetalleVenta(int IdDetalledeventa)
        {
            await EliminarAsync(NombreProcedimientoEliminarDetalledeVenta, new
            {
                IdDetalledeventa
            });
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalle()
        {
            return await ListarAsync<DetalleVentaDto>(NombreProcedimientoListarDetalledeVenta);
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalleVentaPorVenta(int IdVenta)
        {
            return await ListarAsync<DetalleVentaDto>(NombreProcedimientoBuscarDetalledeVenta, new
            {
                IdVenta
            });
        }
    }
}
