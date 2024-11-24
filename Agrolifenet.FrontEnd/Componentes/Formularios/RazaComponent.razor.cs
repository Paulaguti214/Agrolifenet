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
        public IEnumerable<ListarRazaDto> listarRazaDtos = default!;

        public async Task GuardarRaza(RazaGuardaryActualizarDto model)
        {
            var resultado = await HttpConsumir.PostAsync("/api/Raza/InsertarRaza", razaGuardaryActualizarDto);
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {

                await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);

                listarRazaDtos = await ObtenerListado();
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
        public async Task<IEnumerable<ListarRazaDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarRazaDto>>("/api/Raza/ActualizarRaza'");
            return resultadog.Response;
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
                await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
            }
        }
    }
}
