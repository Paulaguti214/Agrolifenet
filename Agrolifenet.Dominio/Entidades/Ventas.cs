namespace Agrolifenet.Dominio.Entidades
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public DateTime FechadecreacionVenta { get; set; }
        public DateTime FechademodificacionVenta { get; set; }
        public bool EstadoVenta { get; set; }
        public DateTime FechaDeLaVenta { get; set; }
        public string NombredelcompradorVenta { get; set; } = string.Empty;
        public string IdentificaciondelcompradorVentas { get; set; } = string.Empty;
        public string Telefonodelcomprador { get; set; } = string.Empty;
        public decimal PrecioVenta { get; set; }
        public string MetododepagoVenta { get; set; } = string.Empty;
        public string DestinoVenta { get; set; } = string.Empty;
        public string CondicionesdeVenta { get; set; } = string.Empty;
        public string EstadodelanimalenVenta { get; set; } = string.Empty;
        public string ObservacionesVenta { get; set; } = string.Empty;
        public int IdUsuario { get; set; }
        public string Correo { get; set; } = string.Empty;
        public Guid ConsecutivoFactura { get; set; }
    }
}
