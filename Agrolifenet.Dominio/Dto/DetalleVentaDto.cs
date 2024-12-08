namespace Agrolifenet.Dominio.Dto
{
    public class DetalleVentaDto
    {
        public int IdDetalledeVenta { get; set; }
        public bool EstadoDetalledeVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdGanado { get; set; }
        public decimal Valor { get; set; }
    }
}
