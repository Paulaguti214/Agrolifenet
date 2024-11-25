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

        private GanadoGuardaryActualizarDto ganadoGuardaryActualizarDto = new() { FechadenacimientoGanado = DateTime.Now.AddYears(-1) };
        public IEnumerable<ListarGanadoDto> listarGanadoDtos = [];

        public async Task<IEnumerable<ListarGanadoDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarGanadoDto>>("/api/Ganado/ListarGanado");
            return resultadog.Response!;
        }

        // Este método se ejecuta cada vez que se actualiza la propiedad
        protected override async void OnParametersSet()
        {
            // Llama a OnDateChanged cada vez que se establece el valor
            await CalcularEdad(ganadoGuardaryActualizarDto.FechadenacimientoGanado);
        }

        private Task CalcularEdad(DateTime fecha)
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - fecha.Year;
            ganadoGuardaryActualizarDto.FechadenacimientoGanado = fecha;
            if (edad < 0)
            {
                ganadoGuardaryActualizarDto.EdadGanado = 0;
            }
            else
            {

                ganadoGuardaryActualizarDto.EdadGanado = edad;
            }

            return Task.CompletedTask;
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
