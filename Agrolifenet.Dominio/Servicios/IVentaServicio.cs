using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IVentaServicio
    {
        Task AgregarVenta(bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
        Task<VentaDto> SeleccionarVenta(int IdVenta);
        Task EliminarVenta(int IdVenta);
        Task ActualizarVenta(int IdVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
    }
}
