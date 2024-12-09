using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    partial class Home : ComponentBase
    {
        private decimal TotalVentas = 0;
        private decimal TotalGanado = 0;
        private double PorcenatejeSanidad = 0;
        private string DescripsionEstadoFinca = string.Empty;
        private string ColorEstadoFinca = string.Empty;

        [Inject] IHttpConsumir HttpConsumir { get; set; } = default!;
        protected override async Task OnInitializedAsync()
        {
            await ObtenerTotalVenta();
            await ObtenerTotalGanado();
            await ObtenerHistorialClinico();
        }

        private async Task ObtenerTotalVenta()
        {

            var resultado = await HttpConsumir.GetAsync<IEnumerable<VentaGuardarActualizarDto>>("/api/Venta/ListarVentas");
            if (!resultado.Error)
            {
                var ventas = resultado.Response!;
                TotalVentas = ventas.Where(venta => venta.FechaDeLaVenta == DateTime.Now.Date).Sum(mes => mes.PrecioVenta);
            }

        }

        private async Task<IEnumerable<GanadoDto>> ObtenerTotalGanado()
        {
            IEnumerable<GanadoDto> ganado = [];
            var resultado = await HttpConsumir.GetAsync<IEnumerable<GanadoDto>>("/api/Ganado/ListarGanado");
            if (!resultado.Error)
            {
                ganado = resultado.Response!;
                var resultadoDetalleVenta = await HttpConsumir.GetAsync<IEnumerable<DetalleVentaGuardarActualizarDto>>($"/api/DetalleVenta/ListarDetalle");
                var detalleVentas = resultadoDetalleVenta.Response;
                var ganadoVendido = detalleVentas!.Where(w => w.EstadoDetalledeVenta).ToList();
                ganado = ganado.Where(ganado => !ganadoVendido.Any(gv => gv.IdGanado == ganado.IdGanado)).ToList();
                TotalGanado = ganado.Count();
            }
            return ganado;
        }

        private async Task ObtenerHistorialClinico()
        {
            var historiales = await HttpConsumir.GetAsync<IEnumerable<HistorialClinicoDto>>("/api/HistorialClinico/ListarHistorialClinicoGeneral");
            if (!historiales.Error)
            {
                var ganado = await ObtenerTotalGanado();
                var ultimosRegistrosHistorial = historiales.Response!
                    .Where(w => ganado.Any(g => g.IdGanado == w.IdGanado))
                    .GroupBy(h => h.IdGanado)
                    .Select(g => g.OrderByDescending(h => h.FechaDeCreacionHistorialClinico).FirstOrDefault()).ToList();

                var cantidGanadoEnfermo = ultimosRegistrosHistorial.Count(historial => historial!.Enfermo);


                PorcenatejeSanidad = ((double)cantidGanadoEnfermo / ganado.Count()) * 100;

                if (PorcenatejeSanidad >= 80)
                {
                    DescripsionEstadoFinca = "No Saludable";
                    ColorEstadoFinca = "danger";
                    return;
                }

                if (PorcenatejeSanidad >= 50 && PorcenatejeSanidad <= 79)
                {
                    DescripsionEstadoFinca = "Estable";
                    ColorEstadoFinca = "info";
                    return;
                }

                if (PorcenatejeSanidad >= 0 && PorcenatejeSanidad <= 49)
                {
                    DescripsionEstadoFinca = "Saludable";
                    ColorEstadoFinca = "success";
                    return;
                }

            }
        }
    }
}
