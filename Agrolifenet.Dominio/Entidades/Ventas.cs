namespace Agrolifenet.Dominio.Entidades
{
    public class Ventas
    {
        public int IdVentas { get; set; }
        public DateTime FechadecreacionVentas { get; set; }
        public DateTime FechademodificacionVentas { get; set; }
        public bool EstadoVentas { get; set; }
        public DateTime FechadeVenta { get; set; }
        public string NombredelcompradorVentas { get; set; }
        public int IdentificaciondelcompradorVentas { get; set; }
        public int TelefonodelcompradorVentas { get; set; }
        public int PreciodeVenta { get; set; }
        public string MetododepagoVentas { get; set; }
        public string DestinoVentas { get; set; }
        public string CondicionesdeVentas { get; set; }
        public string EstadodelanimalVentas { get; set; }
        public string ObservacionVentas { get; set; }
        public int IdUsuario { get; set; }
    }
}
