﻿using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IDetalleVentaServicio
    {
        Task AgregarDetalleVenta(DetalleVentaDto detalleVentaDto);
        Task AgregarVariosDetalleVenta(IEnumerable<DetalleVentaDto> detalleVentaDto);
        Task<IEnumerable<DetalleVentaDto>> ListarDetalleVentaPorVenta(int IdVenta);
        Task EliminarDetalleVenta(int IdDetalledeventa);
        Task ActualizarDetalleVenta(int IdDetalledeventa, bool EstadoDetalledeventa, int IdVenta, int IdGanado);
        Task<IEnumerable<DetalleVentaDto>> ListarDetalle();
    }
}
