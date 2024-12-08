using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class FacturasComponente : ComponentBase
    {
        private IEnumerable<VentaGuardarActualizarDto> ventas = [];
        [Inject] IHttpConsumir HttpConsumir { get; set; } = default!;
        [Inject] IJSRuntime JSRuntime { get; set; } = default!;
        [Inject] SweetAlertService Swal { get; set; } = default!;
        protected override async Task OnInitializedAsync()
        {
            var resultado = await HttpConsumir.GetAsync<IEnumerable<VentaGuardarActualizarDto>>("/api/Venta/ListarVentas");
            if (!resultado.Error)
            {
                ventas = resultado.Response!;
            }
        }
        private async Task DescargarFactura(Guid consecutivoFactura)
        {
            var resultado = await HttpConsumir.GetFileAsync<byte[]>($"/api/Factura/GenerarFactura?consecutivoFactura={consecutivoFactura}");
            if (!resultado.Error)
            {
                var base64File = Convert.ToBase64String(resultado.Response!);
                await JSRuntime.InvokeVoidAsync("downloadFile", base64File, $"{consecutivoFactura}.pdf");
            }
            else
            {
                await Swal.FireAsync("No se genero el documento de la factura", string.Empty, SweetAlertIcon.Error);
            }
        }
    }
}
