using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class HistorialClinicoComponente : ComponentBase
    {
        [Inject] IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject] SweetAlertService Swal { get; set; } = default!;

        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

        private HistorialClinicoGuardar_Actualizar historialClinicoGuardar_Actualizar = new();
        private GanadoGuardaryActualizarDto ganadoDto = default!;

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

        private async Task GanadoSeleccionado(int? idGanado)
        {
            historialClinicoGuardar_Actualizar.IdGanado = idGanado;
            ganadoDto = (historialClinicoGuardar_Actualizar.IdGanado is null ||
                historialClinicoGuardar_Actualizar.IdGanado == 0) ? default! : await BuscarGanado((int)idGanado!);

            historialClinicoGuardar_Actualizar.PesoalnacerHistorialClinico = ganadoDto?.PesoNacido is null ? 0 : (int)ganadoDto.PesoNacido!;
            await CalcularPeso(0);
        }

        private async Task<GanadoGuardaryActualizarDto> BuscarGanado(int idGanado)
        {
            var resultado = await HttpConsumir.GetAsync<GanadoGuardaryActualizarDto>($"/api/Ganado/BuscarGanado?IdGanado={idGanado}");
            return resultado.Response!;
        }
    }
}
