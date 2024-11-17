using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IVentaServicio
    {
        Task AgregarVenta( bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
        Task<Ventas> SeleccionarVenta(int IdVenta);
        Task EliminarVenta(int IdVenta);
        Task ActualizarVenta(int IdVenta,  bool EstadoVenta, DateTime FechadelaVenta, string NombredelcompradorVenta,
            string IdentificaciondelcompradorVentas, string Telefonodelcomprador, double PrecioVenta, string MetododepagoVenta, string DestinoVenta, string CondicionesdeVenta,
            string EstadodelanimalenVenta, string ObservacionesVenta, int IdUsuario);
    }
}
