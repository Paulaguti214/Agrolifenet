namespace Agrolifenet.FrontEnd.Modelos
{
    public class DetalleVentaGuardarActualizarDto
    {
        public int IdDetalledeVenta { get; set; }
        public bool EstadoDetalledeVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdGanado { get; set; }
        public decimal Valor { get; set; }
        public GanadoDto Ganado { get; set; } = default!;
    }
}
