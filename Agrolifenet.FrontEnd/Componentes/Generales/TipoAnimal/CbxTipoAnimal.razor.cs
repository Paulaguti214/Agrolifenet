using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales.TipoAnimal
{
    public partial class CbxTipoAnimal : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;
        private IEnumerable<ListarTipoAnimalDto> ListaTipodeanimal = [];
        [Parameter] public int IdTipoAnimal { get; set; }
        [Parameter] public EventCallback<int> IdTipoAnimalChanged { get; set; }


        protected override async Task OnInitializedAsync()
        {
            try
            {
                await Task.Delay(3000);
                ListaTipodeanimal = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
        public async Task<IEnumerable<ListarTipoAnimalDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarTipoAnimalDto>>("/TipoAnimal/ListarTipoAnimal");
            return resultadog.Response!;
        }

        private int SelectedValueString
        {
            get => IdTipoAnimal; // Suponiendo que Id es un string
            set
            {
                IdTipoAnimalChanged.InvokeAsync(value); // Notifica el cambio al componente padre
            }
        }
        protected override void OnParametersSet()
        {
            // Asegúrate de que el valor seleccionado esté actualizado cuando se establecen los parámetros
            // Solo actualiza SelectedValueString si es diferente al valor actual
            if (SelectedValueString != IdTipoAnimal)
            {
                SelectedValueString = IdTipoAnimal;
            }
        }
    }
}
