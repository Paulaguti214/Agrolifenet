using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class DetalleVentaServicio : IDetalleVentaServicio
    {
        private readonly IDetalleVentaRepositorio _detalleVentaRepositorio;

        public DetalleVentaServicio(IDetalleVentaRepositorio detalleVentaRepositorio)
        {
            _detalleVentaRepositorio = detalleVentaRepositorio;
        }
        public async Task ActualizarDetalleVenta(int IdDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado)
        {
            var fechaActual = DateTime.Now;
            await _detalleVentaRepositorio.ActualizarDetalleVenta(IdDetalledeventa, fechaActual, EstadoDetalledeventa, IdVenta, IdGanado);
        }

        public async Task AgregarDetalleVenta(bool EstadoDetalledeventa, int IdVenta, int IdGanado)
        {
            var fechaActual = DateTime.Now;
            await _detalleVentaRepositorio.AgregarDetalleVenta(fechaActual, fechaActual, EstadoDetalledeventa, IdVenta, IdGanado);
        }

        public async Task EliminarDetalleVenta(int IdDetalledeventa)
        {
            await _detalleVentaRepositorio.EliminarDetalleVenta(IdDetalledeventa);
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalleVenta(int IdVenta)
        {
            return await _detalleVentaRepositorio.ListarDetalleVenta(IdVenta);
        }
    }
}
