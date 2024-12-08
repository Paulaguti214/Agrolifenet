using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IDetalleVentaRepositorio
    {
        Task AgregarDetalleVenta(DetalledeVenta detalledeVenta);
        Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta);
        Task EliminarDetalleVenta(int IdDetalledeventa);
        Task ActualizarDetalleVenta(int IdDetalledeventa, DateTime FechademodificacionDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado);
    }
}
