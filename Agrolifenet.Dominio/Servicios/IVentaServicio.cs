using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IVentaServicio
    {
        Task AgregarVenta(VentaGuardarDto venta);
        Task<Ventas> SeleccionarVenta(Guid ConsecutivoFactura);
        Task<IEnumerable<Ventas>> ListarVentas();
        Task EliminarVenta(int IdVenta);
        Task ActualizarVenta(int IdVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
    }
}
