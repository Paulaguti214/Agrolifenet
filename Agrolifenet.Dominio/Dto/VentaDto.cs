namespace Agrolifenet.Dominio.Dto
{
    public class VentaDto
    {
        public DateTime Fechadelaventa { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string NombredelcompradorVenta { get; set; } = string.Empty;
        public double PrecioVenta { get; set; }

    }
}
