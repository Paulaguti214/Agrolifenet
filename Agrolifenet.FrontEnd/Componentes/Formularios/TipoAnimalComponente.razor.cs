using Agrolifenet.Dominio.Dto;
using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
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
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        private TipoAnimalGuardaryActualizarDto tipoAnimalRegistrarDto = new();
        public IEnumerable<ListarTipoAnimalDto> ListaTipodeanimal = default!;



        public async Task Guardar(TipoAnimalGuardaryActualizarDto model)
        {
            if (tipoAnimalRegistrarDto.IdTipoAnimal == 0)
            {
                var resultado = await HttpConsumir.PostAsync("/TipoAnimal/AgregarTipoAnimal", tipoAnimalRegistrarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {

                    await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
                                      
                    ListaTipodeanimal = await ObtenerListado();
                }

            }
            else
            {
                var resultado = await HttpConsumir.PutAsync("/TipoAnimal/ActualizarTipoanimal", tipoAnimalRegistrarDto);
                if (resultado.Error)
                {
                    await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
                }
                else
                {

                    await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);
                    
                  
                    ListaTipodeanimal = await ObtenerListado();


                }
                tipoAnimalRegistrarDto = new();
            }

        }
        protected override async Task OnInitializedAsync()
        {
            try
            {
               
                ListaTipodeanimal = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
        public async Task EliminarTipoanimal(int IdTipoAnimal)
        {

            var resultado = await HttpConsumir.DeleleteAsync($"/TipoAnimal/EliminarTipoAnimal?idTipoanimal={IdTipoAnimal}");
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                ListaTipodeanimal = ListaTipodeanimal.Where(p => p.IdTipoAnimal != IdTipoAnimal);
                await Swal.FireAsync("Exito", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Success);

            }

        }

        public async Task<IEnumerable<ListarTipoAnimalDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarTipoAnimalDto>>("/TipoAnimal/ListarTipoAnimal");
            return resultadog.Response;
        }

        public async Task ActualizarTipoanimal(int IdTipoAnimal)
        {
            var resultadog = await HttpConsumir.GetAsync<TipoAnimalGuardaryActualizarDto>($"/TipoAnimal/SeleccionarTipoAnimal?idTipoanimal={IdTipoAnimal}");
            tipoAnimalRegistrarDto = resultadog.Response;


            //Navigation.NavigateTo($"/animal/{IdTipoAnimal}", true);
        }



    }
}
