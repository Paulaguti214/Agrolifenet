using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IDetalleVentaRepositorio
    {
        Task AgregarDetalleVenta(DateTime FechadecreacionDetalledeventa, DateTime FechademodificacionDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado);
        Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta);
        Task EliminarDetalleVenta(int IdDetalledeventa);
        Task ActualizarDetalleVenta(int IdDetalledeventa, DateTime FechademodificacionDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado);
    }
}
