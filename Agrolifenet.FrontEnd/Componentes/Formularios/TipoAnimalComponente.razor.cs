using Agrolifenet.Dominio.Dto;
using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Agrolifenet.FrontEnd.Puerto;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Formularios
{
    public partial class TipoAnimalComponente : ComponentBase
   
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        private TipoAnimalRegistrarDto tipoAnimalRegistrarDto = new();
        private IEnumerable<ListarTipoAnimalDto> ListaTipodeanimal = default!;


        public async Task Guardar(TipoAnimalRegistrarDto model)
        {
            var resultado = await HttpConsumir.PostAsync("/TipoAnimal/AgregarTipoAnimal", tipoAnimalRegistrarDto);
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
            }
            Console.WriteLine(tipoAnimalRegistrarDto.EstadoAnimal);
            Console.WriteLine(tipoAnimalRegistrarDto.TipoAnimal);
        }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                // Llama a la API
                var resultado = await HttpConsumir.GetAsync<IEnumerable< ListarTipoAnimalDto>>("/TipoAnimal/ListarTipoAnimal");
                ListaTipodeanimal = resultado.Response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
    }
}
