using System.ComponentModel.DataAnnotations;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class VentaGuardarActualizarDto
    {
        public int IdVenta { get; set; }
        public bool EstadoVenta { get; set; }
        [Required(ErrorMessage = "la feha de venta es obligatorio")]
        public DateTime FechaDeLaVenta { get; set; }
        [Required(ErrorMessage = "el nombre y epellidos del comprador es obligatorio")]
        public string NombreDelCompradorVenta { get; set; } = string.Empty;
        [Required(ErrorMessage = "la identificacion es obligatorio")]
        public string IdentificacionDelCompradorVentas { get; set; } = string.Empty;
        [Required(ErrorMessage = "el telefono es obligatorio")]
        public string TelefonoDelComprador { get; set; } = string.Empty;
        [Required(ErrorMessage = "el precio de venta es obligatorio")]
        public decimal PrecioVenta { get; set; }
        [Required(ErrorMessage = "el metodo de pago es obligatorio")]
        public string MetodoDePagoVenta { get; set; } = string.Empty;
        [Required(ErrorMessage = "la informacion del destino es obligatorio")]
        public string DestinoVenta { get; set; } = string.Empty;
        [Required(ErrorMessage = "la informacion del correo es obligatorio")]
        public string Correo { get; set; } = string.Empty;
        public string CondicionesDeVenta { get; set; } = string.Empty;
        public string EstadoDelAnimalEnVenta { get; set; } = string.Empty;
        public string ObservacionesVenta { get; set; } = string.Empty;
        public int IdUsuario { get; set; }
        public Guid ConsecutivoFactura { get; set; }
        public List<DetalleVentaGuardarActualizarDto> detalleVentas { get; set; } = [];

    }
}
