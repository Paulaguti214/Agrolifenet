using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class VentaServicio : IVentaServicio
    {
        private readonly IVentaRepositorio _ventaRepositorio;
        public VentaServicio(IVentaRepositorio ventaRepositorio)
        {
            _ventaRepositorio = ventaRepositorio;
        }
        public async Task AgregarVenta(VentaGuardarDto ventaDto)
        {
            var fechaActual = DateTime.Now;
            Ventas venta = new()
            {
                FechadecreacionVenta = fechaActual,
                FechademodificacionVenta = fechaActual,
                EstadoVenta = ventaDto.EstadoVenta,
                FechaDeLaVenta = ventaDto.FechaDeLaVenta,
                NombredelcompradorVenta = ventaDto.NombreDelCompradorVenta,
                IdentificaciondelcompradorVentas = ventaDto.IdentificacionDelCompradorVentas,
                Telefonodelcomprador = ventaDto.TelefonoDelComprador,
                PrecioVenta = ventaDto.PrecioVenta,
                MetododepagoVenta = ventaDto.MetodoDePagoVenta,
                DestinoVenta = ventaDto.DestinoVenta,
                CondicionesdeVenta = ventaDto.CondicionesDeVenta,
                EstadodelanimalenVenta = ventaDto.EstadoDelAnimalEnVenta,
                ObservacionesVenta = ventaDto.ObservacionesVenta,
                IdUsuario = ventaDto.IdUsuario,
                Correo = ventaDto.Correo,
                ConsecutivoFactura = ventaDto.ConsecutivoFactura
            };
            await _ventaRepositorio.AgregarVenta(venta);
        }
        public async Task<Ventas> SeleccionarVenta(Guid ConsecutivoFactura)
        {
            return await _ventaRepositorio.SeleccionarVenta(ConsecutivoFactura);
        }
        public async Task EliminarVenta(int IdVenta)
        {
            await _ventaRepositorio.EliminarVenta(IdVenta);
        }
        public async Task ActualizarVenta(int IdVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta, string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta, string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            var fechaActual = DateTime.Now;
            await _ventaRepositorio.ActualizarVenta(IdVenta, fechaActual, EstadoVenta, FechadelaVenta, NombredelcompradorVenta, IdentificaciondelcompradorVentas, Telefonodelcomprador, PrecioVenta, MetododepagoVenta, DestinoVenta, CondicionesdeVenta, EstadodelanimalenVenta, ObservacionesVenta, IdUsuario);
        }

        public async Task<IEnumerable<Ventas>> ListarVentas()
        {
            return await _ventaRepositorio.ListarVentas();
        }
    }
}
