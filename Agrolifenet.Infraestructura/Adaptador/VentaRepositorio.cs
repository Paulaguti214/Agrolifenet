using Agrolifenet.Dominio.Dto;
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
        public VentaRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }



        public async Task AgregarVenta(DateTime FechadecreacionVenta, DateTime FechademodificacionVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta, string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta, string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            await AgregarAsync(NombreProcedimientoGuardarVenta, new
            {
                FechadecreacionVenta,
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
        public async Task<VentaDto> SeleccionarVenta(int IdVenta)
        {
            return await SeleccionarAsync<VentaDto>(NombreProcedimientoSeleccionarVenta, new
            {
                IdVenta
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
            await ActualiozarAsync(NombreProcedimientoActualizarVenta, new
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


    }
}
