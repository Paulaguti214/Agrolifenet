using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales.Raza
{
    public partial class CbxRaza : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;
        [Parameter] public int IdRaza { get; set; }
        [Parameter] public EventCallback<int> IdRazaChanged { get; set; }

        private IEnumerable<ListarRazaDto> ListaRazas = [];

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await Task.Delay(3000);
                ListaRazas = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
        public async Task<IEnumerable<ListarRazaDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<ListarRazaDto>>("/api/Raza/LisatarRaza");
            return resultadog.Response!;
        }

        private int SeleccionarRaza
        {
            get => IdRaza;
            set
            {
                IdRazaChanged.InvokeAsync(value);
            }
        }
        protected override void OnParametersSet()
        {
            if (SeleccionarRaza != IdRaza)
            {
                SeleccionarRaza = IdRaza;
            }
        }
    }
}
