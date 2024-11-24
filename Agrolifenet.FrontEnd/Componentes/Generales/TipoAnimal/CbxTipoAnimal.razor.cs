using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales.TipoAnimal
{
    public partial class CbxTipoAnimal : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;
        [Parameter] public int IdTipoAnimal { get; set; }
        [Parameter] public EventCallback<int> IdTipoAnimalChanged { get; set; }

        private IEnumerable<ListarTipoAnimalDto> ListaTipodeanimal = [];

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

        private int TipoAnimalSeleccionado
        {
            get => IdTipoAnimal;
            set
            {
                IdTipoAnimalChanged.InvokeAsync(value);
            }
        }
        protected override void OnParametersSet()
        {
            if (TipoAnimalSeleccionado != IdTipoAnimal)
            {
                TipoAnimalSeleccionado = IdTipoAnimal;
            }
        }
    }
}
