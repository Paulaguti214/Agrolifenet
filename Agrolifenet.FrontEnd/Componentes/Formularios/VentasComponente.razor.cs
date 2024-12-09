using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class VentasComponente : ComponentBase
    {
        [Inject] IHttpConsumir HttpConsumir { get; set; } = default!;
        [Inject] SweetAlertService Swal { get; set; } = default!;
        [Inject] IJSRuntime JSRuntime { get; set; } = default!;
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        private string NumeroChipBuscar { get; set; } = default!;

        private const decimal valorKilo = 25000;

        private VentaGuardarActualizarDto ventaGuardarActualizar = new();

        private bool AgregarDetalle = false;
        private bool PuedeGuardarVenta = true;

        protected override async Task OnInitializedAsync()
        {
            await EstablecerInformacionUsuario();
        }

        private async Task EstablecerInformacionUsuario()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var idUsuario = authState.User.Claims.FirstOrDefault(w => w.Type == "IdUsuario")!.Value;

            ventaGuardarActualizar.detalleVentas = [];
            ventaGuardarActualizar.EstadoVenta = true;
            ventaGuardarActualizar.ConsecutivoFactura = Guid.NewGuid();
            ventaGuardarActualizar.IdUsuario = int.Parse(idUsuario);
            ventaGuardarActualizar.FechaDeLaVenta = DateTime.Now;
            NumeroChipBuscar = string.Empty;
            PuedeGuardarVenta = true;
        }

        private async Task BuscarGanado()
        {
            if (string.IsNullOrEmpty(NumeroChipBuscar))
            {
                await Swal.FireAsync("Consulta algun # de chip", string.Empty, SweetAlertIcon.Error);
                return;
            }

            var resultadoGanado = await HttpConsumir.GetAsync<GanadoDto>($"/api/Ganado/BuscarGanado?numeroChip={NumeroChipBuscar}");
            if (!resultadoGanado.Error)
            {
                var existe = await ExisteGanadoRegistrado(NumeroChipBuscar, resultadoGanado.Response!.IdGanado);
                if (existe)
                {
                    await Swal.FireAsync("Ganado ya registrado", string.Empty, SweetAlertIcon.Warning);
                    return;
                }

            }




            if (!resultadoGanado.Error)
            {
                SweetAlertResult resultadoSeleccionado = await Swal.FireAsync(new SweetAlertOptions
                {
                    Title = $"Se encontro informacion relacionado con el chip # {NumeroChipBuscar}",
                    Text = "Desea agregarlo a la factura",
                    Icon = SweetAlertIcon.Info,
                    ShowCancelButton = true,
                    ConfirmButtonText = "Si",
                    CancelButtonText = "No",
                });

                if (bool.Parse(resultadoSeleccionado.Value) == true)
                {
                    var valorDijitado = new Func<Task<string>>(async () =>
                    {
                        var valor = await JSRuntime.InvokeAsync<string>("eval", "document.getElementById('TxtPeso').value");
                        return valor;

                    });

                    resultadoSeleccionado = await Swal.FireAsync(new SweetAlertOptions
                    {
                        Title = $"ingresar el peso del animal con chip # {NumeroChipBuscar}",
                        Icon = SweetAlertIcon.Info,
                        Html = "<input id='TxtPeso' class='swal2-input' placeholder='Peso del animal' />",
                        ShowCancelButton = true,
                        ConfirmButtonText = "Si",
                        CancelButtonText = "No",
                        PreConfirm = new PreConfirmCallback(valorDijitado)
                    });

                    var ganado = resultadoGanado.Response!;
                    var valor = valorKilo * decimal.Parse(resultadoSeleccionado.Value);
                    ventaGuardarActualizar.detalleVentas.Add(new DetalleVentaGuardarActualizarDto() { IdDetalledeVenta = 0, Valor = valor, IdGanado = ganado.IdGanado, Ganado = ganado });
                    ventaGuardarActualizar.PrecioVenta = ventaGuardarActualizar.detalleVentas.Sum(detalle => detalle.Valor);
                    NumeroChipBuscar = string.Empty;
                    PuedeGuardarVenta = true;
                }
            }

        }

        private async Task<bool> ExisteGanadoRegistrado(string numerodelchipGanado, int idGanado)
        {
            var resultadoDetalleVenta = await HttpConsumir.GetAsync<IEnumerable<DetalleVentaGuardarActualizarDto>>($"/api/DetalleVenta/ListarDetalle");
            if (!resultadoDetalleVenta.Error)
            {
                var detalleVenta = resultadoDetalleVenta.Response;
                if (detalleVenta!.Any(detalle => detalle.EstadoDetalledeVenta && detalle.IdGanado == idGanado))
                {
                    return true;
                };
            }

            return ventaGuardarActualizar.detalleVentas.Any(detalle => detalle.Ganado.NumerodelchipGanado == numerodelchipGanado);
        }

        private void EliminarDetalle(int idDetalleVenta, int idGanado)
        {
            if (idDetalleVenta != 0)
            {
                //eliminar en la Db
            }
            ventaGuardarActualizar.detalleVentas.RemoveAll(detalle => detalle.IdDetalledeVenta == idDetalleVenta || detalle.IdGanado == idGanado);
            if (!ventaGuardarActualizar.detalleVentas.Any())
            {
                PuedeGuardarVenta = false;
            }
        }

        public async Task GuardarVenta(VentaGuardarActualizarDto venta)
        {
            AgregarDetalle = true;
            if (venta.detalleVentas.Count == 0)
            {
                await Swal.FireAsync("El detalle de venta esta vacio", string.Empty, SweetAlertIcon.Error);
                PuedeGuardarVenta = false;
                return;
            }

            if (venta.IdVenta == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/api/Venta/InsertarVenta", venta);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    var encabezado = await HttpConsumir.GetAsync<VentaGuardarActualizarDto>($"/api/Venta/BuscarVenta?ConsecutivoFactura={venta.ConsecutivoFactura}");

                    if (!encabezado.Error)
                    {
                        venta.IdVenta = encabezado.Response!.IdVenta;
                        var detalleVenta = venta.detalleVentas.Select(detalle => new DetalleVentaGuardarActualizarDto() { IdDetalledeVenta = detalle.IdDetalledeVenta, EstadoDetalledeVenta = true, IdGanado = detalle.IdGanado, IdVenta = venta.IdVenta, Valor = detalle.Valor });
                        var resultadoDetalleVenta = await HttpConsumir.PostAsync($"/api/DetalleVenta/InsertarVariosDetalleVenta", detalleVenta);
                        if (!resultadoDetalleVenta.Error)
                        {
                            await Swal.FireAsync("Exito", "Se Guardo Exitosamente", SweetAlertIcon.Success);
                            Navigation.NavigateTo("/Ventas", true);
                        }
                    }
                }
            }
        }
    }
}
