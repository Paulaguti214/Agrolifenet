using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Dto
{
    public class FacturaDto
    {
        public Ventas Venta { get; set; } = default!;
        public IEnumerable<DetalleFacturaDto> DetalledeVenta { get; set; } = default!;
    }
}
