namespace Agrolifenet.Dominio.Entidades
{
    public class DetalledeVenta
    {
        public int IdDetalledeVenta { get; set; }
        public DateTime FechadecreacionDetalledeVenta { get; set; }
        public DateTime FechademodificacionDetalledeVenta { get; set; }
        public bool EstadoDetalledeVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdGanado { get; set; }
        public decimal Valor { get; set; }
    }
}
