using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IVentaRepositorio : IRepositorio<Ventas>
    {
        Task AgregarVenta(DateTime FechadecreacionVenta, DateTime FechademodificacionVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
        Task<Ventas> SeleccionarVenta(int IdVenta);
        Task EliminarVenta(int IdVenta);
        Task ActualizarVenta(int IdVenta, DateTime FechademodificacionVenta, bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);

    }
}
