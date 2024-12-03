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

        private HistorialClinicoGuardarActualizar historialClinicoGuardar_Actualizar = new();
        private GanadoGuardaryActualizarDto ganadoDto = default!;
        private IEnumerable<HistorialClinicoDto> historialClinicos = [];

        protected override async Task OnInitializedAsync()
        {
            await EstablecerInformacionUsuario();
        }

        public async Task GuardarHistorialClinico(HistorialClinicoGuardarActualizar model)
        {
            if (model.IdHistorialClinico == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/api/HistorialClinico/AgregarHistorialClinico", historialClinicoGuardar_Actualizar);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Guardo Con Exito", SweetAlertIcon.Success);
                    historialClinicoGuardar_Actualizar = new();
                    historialClinicos = [];
                    await GanadoSeleccionado(default!);
                }
            }
            else
            {
                var resultado = await HttpConsumir.PutAsync("/api/HistorialClinico/ActualizarHistorialClinico", model);

                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Actualizo Con Exito", SweetAlertIcon.Success);

                    historialClinicoGuardar_Actualizar = new();
                    historialClinicos = [];
                    await GanadoSeleccionado(default!);
                }
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

            if (ganadoDto is not null)
            {
                historialClinicoGuardar_Actualizar.PesoalnacerHistorialClinico = ganadoDto!.PesoNacido is null ? 0 : (int)ganadoDto.PesoNacido!;
                await CalcularPeso(ganadoDto!.PesoNacido);
                historialClinicos = historialClinicoGuardar_Actualizar.IdGanado is null ? [] : await ObtenerHistorialesClinicosDelGanadoSeleccionado((int)historialClinicoGuardar_Actualizar.IdGanado);
            }
            else
            {
                historialClinicoGuardar_Actualizar = new();
                await EstablecerInformacionUsuario();
            }
        }

        private async Task<IEnumerable<HistorialClinicoDto>> ObtenerHistorialesClinicosDelGanadoSeleccionado(int idGanado)
        {
            var resultado = await HttpConsumir.GetAsync<IEnumerable<HistorialClinicoDto>>($"/api/HistorialClinico/ListarHistorialClinico?IdGanado={idGanado}");
            return resultado.Response!;
        }

        private async Task<GanadoGuardaryActualizarDto> BuscarGanado(int idGanado)
        {
            var resultado = await HttpConsumir.GetAsync<GanadoGuardaryActualizarDto>($"/api/Ganado/BuscarGanado?IdGanado={idGanado}");
            return resultado.Response!;
        }

        private async Task EstablecerInformacionUsuario()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var idUsuario = authState.User.Claims.FirstOrDefault(w => w.Type == "IdUsuario")!.Value;

            historialClinicoGuardar_Actualizar.NombreUsuario = authState.User.Identity?.Name!;
            historialClinicoGuardar_Actualizar.IdUsuario = int.Parse(idUsuario);
        }

        public async Task ActualizarHistorialClinico(int IdGanado)
        {
            var resultado = await HttpConsumir.GetAsync<HistorialClinicoDto>($"/api/HistorialClinico/SeleccionarHistorialClinico?IdHistorialclinico={IdGanado}");
            if (resultado.Error == false)
            {
                historialClinicoGuardar_Actualizar.IdHistorialClinico = resultado.Response!.IdHistorialClinico;
                historialClinicoGuardar_Actualizar.EstadoHistorialClinico = resultado.Response!.EstadoHistorialClinico;
                historialClinicoGuardar_Actualizar.VacunaHistorialClinico = resultado.Response!.VacunasHistorialClinico;
                historialClinicoGuardar_Actualizar.TratamientoHistorialClinico = resultado.Response!.TratamientosHistorialClinico;
                historialClinicoGuardar_Actualizar.EnfermedadesHistorialClinico = resultado.Response!.EnfermedadesHistorialClinico;
                historialClinicoGuardar_Actualizar.ResultadodeExamenesHistorialClinico = resultado.Response!.ResultadosDeExamenesHistorialClinico;
                historialClinicoGuardar_Actualizar.InformaciondesparacitacionHistorialClinico = resultado.Response!.InformacionDesparacitacionHistorialClinico;
                historialClinicoGuardar_Actualizar.PesoalnacerHistorialClinico = resultado.Response!.PesoAlNacerHistorialClinico;
                historialClinicoGuardar_Actualizar.PesoactualHistorialClinico = resultado.Response!.PesoActualHistorialClinico;
                historialClinicoGuardar_Actualizar.GananciadepesodiariaHistorialClinico = resultado.Response!.GananciaDePesoDiariaHistorialClinico;
                historialClinicoGuardar_Actualizar.ObservacionesHistorialClinico = resultado.Response!.ObservacionesHistorialClinico;
                historialClinicoGuardar_Actualizar.EstadodesaludHistorialClinico = resultado.Response!.EstadoDeSaludHistorialClinico;
                historialClinicoGuardar_Actualizar.CostodeltratamientoHistorialClinico = resultado.Response!.CostoDelTratamientoHistorialClinico;
                historialClinicoGuardar_Actualizar.SeguimientoHistorialClinico = resultado.Response!.SeguimientoHistorialClinico;
                historialClinicoGuardar_Actualizar.NumerodepartosHistorialClinico = resultado.Response!.NumeroDePartosHistorialClinico;
                historialClinicoGuardar_Actualizar.IdGanado = resultado.Response!.IdGanado;
                historialClinicoGuardar_Actualizar.IdUsuario = resultado.Response!.IdUsuario;
                historialClinicoGuardar_Actualizar.NombreUsuario = resultado.Response!.NombreUsuario;
                await EstablecerInformacionUsuario();
            }

            await Swal.FireAsync("Exito", "Se Buco Con Exito", SweetAlertIcon.Success);
        }

        public async Task EliminarHistorial(int idHistorialClinico)
        {
            var resultado = await HttpConsumir.DeleleteAsync($"/api/HistorialClinico/EliminarHistorialClinico?IdHistorialclinico={idHistorialClinico}");
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                historialClinicos = historialClinicos.Where(historial => historial.IdHistorialClinico != idHistorialClinico);
                await Swal.FireAsync("Exito", "Se Elimino Con Exito", SweetAlertIcon.Success);
            }
        }
    }
}
