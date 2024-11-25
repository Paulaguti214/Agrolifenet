using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class GanadoComponent : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        private GanadoGuardaryActualizarDto ganadoGuardaryActualizarDto = new();
        public IEnumerable<ListarGanadoDto> listarGanadoDtos = [];

        public async Task<IEnumerable<ListarGanadoDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarGanadoDto>>("/api/Ganado/ListarGanado");
            return resultadog.Response!;
        }
        private void CalcularEdad()
        {
            if (ganadoGuardaryActualizarDto.FechadenacimientoGanado != null)
            {
                var hoy = DateTime.Today;
                ganadoGuardaryActualizarDto.EdadGanado = hoy.Year - ganadoGuardaryActualizarDto.FechadenacimientoGanado.Year;
            }
            else
            {
                ganadoGuardaryActualizarDto.EdadGanado = 0;
            }
        }


        private void OnDateChanged()
        {
            CalcularEdad();
        }

        protected override void OnParametersSet()
        {
            OnDateChanged();
        }
        public async Task GuardarGanado(GanadoGuardaryActualizarDto model)
        {
            if (ganadoGuardaryActualizarDto.IdGanado == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/api/Raza/InsertarRaza", ganadoGuardaryActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {

                    await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);

                    listarGanadoDtos = await ObtenerListado();
                }
            }
            else
            {
                //var resultado = await HttpConsumir.PutAsync("/api/Raza/ActualizarRaza", razaGuardaryActualizarDto);
                //if (resultado.Error)
                //{
                //    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                //}
                //else
                //{
                //    await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
                //}
                ganadoGuardaryActualizarDto = new();
            }
        }
    }
}
