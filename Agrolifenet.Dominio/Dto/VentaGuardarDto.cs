namespace Agrolifenet.Dominio.Dto
{
    public class VentaGuardarDto
    {
        public bool EstadoVenta { get; set; }
        public DateTime FechaDeLaVenta { get; set; }
        public string NombreDelCompradorVenta { get; set; } = string.Empty;
        public string IdentificacionDelCompradorVentas { get; set; } = string.Empty;
        public string TelefonoDelComprador { get; set; } = string.Empty;
        public decimal PrecioVenta { get; set; }
        public string MetodoDePagoVenta { get; set; } = string.Empty;
        public string DestinoVenta { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string CondicionesDeVenta { get; set; } = string.Empty;
        public string EstadoDelAnimalEnVenta { get; set; } = string.Empty;
        public string ObservacionesVenta { get; set; } = string.Empty;
        public int IdUsuario { get; set; }
        public Guid ConsecutivoFactura { get; set; }

    }
}
