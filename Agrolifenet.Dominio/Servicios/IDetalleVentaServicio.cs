using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IDetalleVentaServicio
    {
        Task AgregarDetalleVenta(bool EstadoDetalledeventa, int IdVenta, int IdGanado);
        Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta);
        Task EliminarDetalleVenta(int IdDetalledeventa);
        Task ActualizarDetalleVenta(int IdDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado);
    }
}
