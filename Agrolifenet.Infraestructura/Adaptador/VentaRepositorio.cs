using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class VentaRepositorio : Repositorio<Ventas>, IVentaRepositorio
    {
        private readonly string NombreProcedimientoGuardarVenta = "InsertarVenta";
        private readonly string NombreProcedimientoSeleccionarVenta = "BuscarVenta";
        private readonly string NombreProcedimientoEliminarVenta = "EliminarVenta";
        private readonly string NombreProcedimientoActualizarVenta = "ActualizarVenta";
        private readonly string NombreProcedimientoListarVenta = "ListarVentas";

        public VentaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }

        public async Task AgregarVenta(Ventas venta)
        {
            await AgregarAsync(NombreProcedimientoGuardarVenta, new
            {
                venta.FechadecreacionVenta,
                venta.FechademodificacionVenta,
                venta.EstadoVenta,
                venta.FechaDeLaVenta,
                venta.NombredelcompradorVenta,
                venta.IdentificaciondelcompradorVentas,
                venta.Telefonodelcomprador,
                venta.PrecioVenta,
                venta.MetododepagoVenta,
                venta.DestinoVenta,
                venta.CondicionesdeVenta,
                venta.EstadodelanimalenVenta,
                venta.ObservacionesVenta,
                venta.IdUsuario,
                venta.Correo,
                venta.ConsecutivoFactura
            });
        }
        public async Task<Ventas> SeleccionarVenta(Guid ConsecutivoFactura)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarVenta, new
            {
                ConsecutivoFactura
            });
        }

        public async Task EliminarVenta(int IdVenta)
        {
            await EliminarAsync(NombreProcedimientoEliminarVenta, new
            {
                IdVenta
            });
        }
        public async Task ActualizarVenta(int IdVenta, DateTime FechademodificacionVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta, string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta, string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            await ActualizarAsync(NombreProcedimientoActualizarVenta, new
            {
                IdVenta,
                FechademodificacionVenta,
                EstadoVenta,
                FechadelaVenta,
                NombredelcompradorVenta,
                IdentificaciondelcompradorVentas,
                Telefonodelcomprador,
                PrecioVenta,
                MetododepagoVenta,
                DestinoVenta,
                CondicionesdeVenta,
                EstadodelanimalenVenta,
                ObservacionesVenta,
                IdUsuario

            });
        }

        public async Task<IEnumerable<Ventas>> ListarVentas()
        {
            return await ListarAsync(NombreProcedimientoListarVenta);
        }
    }
}
