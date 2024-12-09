using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    partial class Home : ComponentBase
    {
        private decimal TotalVentas = 0;
        private decimal TotalGanado = 0;

        [Inject] IHttpConsumir HttpConsumir { get; set; } = default!;
        protected override async Task OnInitializedAsync()
        {
            await ObtenerTotalVenta();
            await ObtenerTotalGanado();
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

        private async Task ObtenerTotalGanado()
        {
            var resultado = await HttpConsumir.GetAsync<IEnumerable<GanadoDto>>("/api/Ganado/ListarGanado");
            if (!resultado.Error)
            {
                var ganado = resultado.Response!;
                TotalGanado = ganado.Where(w => w.EstadoGanado).Count();

                var resultadoDetalleVenta = await HttpConsumir.GetAsync<IEnumerable<DetalleVentaGuardarActualizarDto>>($"/api/DetalleVenta/ListarDetalle");
                var detalleVentas = resultadoDetalleVenta.Response;
                var ganadoVendido = detalleVentas!.Where(w => w.EstadoDetalledeVenta).ToList();
                TotalGanado = ganado.Count(ganado => !ganadoVendido.Exists(gv => gv.IdGanado == ganado.IdGanado));
            }
        }
    }
}
