using Agrolifenet.Dominio.Dto;
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
        public async Task AgregarVenta(bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta, string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta, string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario)
        {
            var fechaActual = DateTime.Now;
            await _ventaRepositorio.AgregarVenta(fechaActual, fechaActual, EstadoVenta, FechadelaVenta, NombredelcompradorVenta, IdentificaciondelcompradorVentas, Telefonodelcomprador, PrecioVenta, MetododepagoVenta, DestinoVenta, CondicionesdeVenta, EstadodelanimalenVenta, ObservacionesVenta, IdUsuario);
        }
        public async Task<VentaDto> SeleccionarVenta(int IdVenta)
        {
            return await _ventaRepositorio.SeleccionarVenta(IdVenta);
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






    }
}
