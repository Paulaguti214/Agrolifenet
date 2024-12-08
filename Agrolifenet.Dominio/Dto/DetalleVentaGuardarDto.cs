namespace Agrolifenet.Dominio.Dto
{
    public class DetalleVentaGuardarDto
    {
        public int IdDetalledeVenta { get; set; }
        public bool EstadoDetalledeVenta { get; set; }
        public int IdVentas { get; set; }
        public int IdGanado { get; set; }
    }
}
