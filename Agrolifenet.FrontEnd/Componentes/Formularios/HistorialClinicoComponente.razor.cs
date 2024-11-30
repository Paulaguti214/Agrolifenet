using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class HistorialClinicoComponente : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

        public HistorialClinicoGuardar_Actualizar historialClinicoGuardar_Actualizar = new();

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var idUsuario = authState.User.Claims.FirstOrDefault(w => w.Type == "IdUsuario")!.Value;

            historialClinicoGuardar_Actualizar.NombreUsuario = authState.User.Identity?.Name!;
            historialClinicoGuardar_Actualizar.IdUsuario = int.Parse(idUsuario);
        }

        public async Task GuardarHistorialClinico(HistorialClinicoGuardar_Actualizar model)
        {
            var resultado = await HttpConsumir.PostAsync("/api/HistorialClinico/AgregarHistorialClinico", historialClinicoGuardar_Actualizar);
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                await Swal.FireAsync("Exito", "Se Guardo Con Exito", SweetAlertIcon.Success);
            }
        }

        private Task CalcularPeso(int? pesoActual)
        {
            historialClinicoGuardar_Actualizar.PesoactualHistorialClinico = pesoActual ?? 0;
            historialClinicoGuardar_Actualizar.GananciadepesodiariaHistorialClinico = (pesoActual ?? 0) - historialClinicoGuardar_Actualizar.PesoalnacerHistorialClinico;

            return Task.CompletedTask;
        }
    }
}
