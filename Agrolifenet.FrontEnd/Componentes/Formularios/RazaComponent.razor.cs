using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class RazaComponent : ComponentBase
    {

        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        private RazaGuardaryActualizarDto razaGuardaryActualizarDto = new();
        private IEnumerable<ListarRazaDto> listarRazaDtos = [];

        public async Task GuardarRaza(RazaGuardaryActualizarDto model)
        {
            if (razaGuardaryActualizarDto.IdRaza == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/api/Raza/InsertarRaza", razaGuardaryActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Guardo Con Exito", SweetAlertIcon.Success);

                    listarRazaDtos = await ObtenerListado();
                }
            }
            else
            {
                var resultado = await HttpConsumir.PutAsync("/api/Raza/ActualizarRaza", razaGuardaryActualizarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {
                    await Swal.FireAsync("Exito", "Se Actualizo Con Exito", SweetAlertIcon.Success);
                    listarRazaDtos = await ObtenerListado();
                }
                razaGuardaryActualizarDto = new();

            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                listarRazaDtos = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }

        public async Task EliminarRaza(int IdRaza)
        {
            var resultado = await HttpConsumir.DeleleteAsync($"/api/Raza/EliminarRaza?IdRaza={IdRaza}");
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                listarRazaDtos = listarRazaDtos.Where(raza => raza.IdRaza != IdRaza);
                await Swal.FireAsync("Exito", "Eliminado Con Exito", SweetAlertIcon.Success);
            }
        }

        public async Task<IEnumerable<ListarRazaDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarRazaDto>>("/api/Raza/LisatarRaza");
            return resultadog.Response!;
        }


        public async Task ActualizarRaza(int IdRaza)
        {
            var resultadog = await HttpConsumir.GetAsync<RazaGuardaryActualizarDto>($"/api/Raza/BuscarRaza?IdRaza={IdRaza}");
            razaGuardaryActualizarDto = resultadog.Response!;

            await Swal.FireAsync("Exito", "Se Busco Con Exito", SweetAlertIcon.Success);
        }

        private async Task TipoAnimalSeleccionado(int idTipoAnimal)
        {
            razaGuardaryActualizarDto.IdTipoAnimal = idTipoAnimal;
            await Task.FromResult(razaGuardaryActualizarDto);
        }
    }
}
