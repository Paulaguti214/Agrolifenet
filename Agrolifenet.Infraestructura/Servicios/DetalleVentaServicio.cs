using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
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

        public async Task AgregarDetalleVenta(DetalleVentaDto detalleVentaDto)
        {
            var fechaActual = DateTime.Now;
            DetalledeVenta detalleVenta = new()
            {
                IdDetalledeVenta = detalleVentaDto.IdDetalledeVenta,
                FechadecreacionDetalledeVenta = fechaActual,
                FechademodificacionDetalledeVenta = fechaActual,
                EstadoDetalledeVenta = detalleVentaDto.EstadoDetalledeVenta,
                IdVenta = detalleVentaDto.IdVenta,
                IdGanado = detalleVentaDto.IdGanado,
                Valor = detalleVentaDto.Valor
            };

            await _detalleVentaRepositorio.AgregarDetalleVenta(detalleVenta);
        }

        public async Task AgregarVariosDetalleVenta(IEnumerable<DetalleVentaDto> detalleVentaDto)
        {
            var fechaActual = DateTime.Now;
            foreach (var detalle in detalleVentaDto)
            {
                DetalledeVenta detalleVenta = new()
                {
                    IdDetalledeVenta = detalle.IdDetalledeVenta,
                    FechadecreacionDetalledeVenta = fechaActual,
                    FechademodificacionDetalledeVenta = fechaActual,
                    EstadoDetalledeVenta = detalle.EstadoDetalledeVenta,
                    IdVenta = detalle.IdVenta,
                    IdGanado = detalle.IdGanado,
                    Valor = detalle.Valor
                };

                await _detalleVentaRepositorio.AgregarDetalleVenta(detalleVenta);
            }
        }

        public async Task EliminarDetalleVenta(int IdDetalledeventa)
        {
            await _detalleVentaRepositorio.EliminarDetalleVenta(IdDetalledeventa);
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalle()
        {
            return await _detalleVentaRepositorio.ListarDetalle();
        }

        public async Task<IEnumerable<DetalleVentaDto>> ListarDetalleVentaPorVenta(int IdVenta)
        {
            return await _detalleVentaRepositorio.ListarDetalleVentaPorVenta(IdVenta);
        }
    }
}
