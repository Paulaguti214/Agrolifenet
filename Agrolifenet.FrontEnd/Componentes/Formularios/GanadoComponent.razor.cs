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

        private GanadoGuardaryActualizarDto ganadoGuardaryActualizarDto = new() { FechadenacimientoGanado = DateTime.Now };
        private IEnumerable<GanadoDto> listarGanadoDtos = [];
        protected override async Task OnInitializedAsync()
        {
            try
            {
                listarGanadoDtos = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }

        protected override async void OnParametersSet()
        {
            await CalcularEdad(ganadoGuardaryActualizarDto.FechadenacimientoGanado);
        }

        public async Task<IEnumerable<GanadoDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<GanadoDto>>("/api/Ganado/ListarGanado");
            return resultadog.Response!;
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
                var resultado = await HttpConsumir.PostAsync("/api/Ganado/InsertarGanado", ganadoGuardaryActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Guardo Exitosamente", SweetAlertIcon.Success);
                    listarGanadoDtos = await ObtenerListado();
                }
            }
            else
            {
                var resultado = await HttpConsumir.PutAsync("/api/Ganado/ActualizarGanado", ganadoGuardaryActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Actualizo Con Exito", SweetAlertIcon.Success);

                    listarGanadoDtos = await ObtenerListado();
                    ganadoGuardaryActualizarDto = new() { FechadenacimientoGanado = DateTime.Now };
                }
            }
        }

        public async Task ActualizarGanado(int IdGanado)
        {
            var resultadog = await HttpConsumir.GetAsync<GanadoGuardaryActualizarDto>($"/api/Ganado/BuscarGanado?IdGanado={IdGanado}");
            ganadoGuardaryActualizarDto = resultadog.Response!;
            ganadoGuardaryActualizarDto.FechadenacimientoGanado = DateTime.Now.AddYears(-ganadoGuardaryActualizarDto.EdadGanado);
            await Swal.FireAsync("Exito", "Se Buco Con Exito", SweetAlertIcon.Success);
        }

        public async Task EliminarGanado(int IdGanado)
        {
            var resultado = await HttpConsumir.DeleleteAsync($"/api/Ganado/EliminarGanado?IdGanado={IdGanado}");
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                listarGanadoDtos = listarGanadoDtos.Where(raza => raza.IdGanado != IdGanado);
                await Swal.FireAsync("Exito", "Se Elimino Con Exito", SweetAlertIcon.Success);
            }
        }

        private async Task TipoAnimalSeleccionado(int idTipoAnimal)
        {
            ganadoGuardaryActualizarDto.IdTipoAnimal = idTipoAnimal;

            await Task.CompletedTask;
        }
    }
}
