using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IFacturaServicio
    {
        Task<byte[]> GenerarFacturaAsync(Guid consecutivoFactura);
        Task<IEnumerable<Ventas>> VerFacturaAsync();
    }
}
