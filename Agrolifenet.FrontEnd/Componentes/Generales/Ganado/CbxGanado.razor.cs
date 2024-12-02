using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Agrolifenet.FrontEnd.Modelos.Enumeraciones;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales.Ganado
{
    public partial class CbxGanado : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;
        [Parameter] public Sexo? Sexo { get; set; } = Modelos.Enumeraciones.Sexo.Ninguno!;
        [Parameter] public int? IdGanado { get; set; }
        [Parameter] public EventCallback<int?> IdGanadoChanged { get; set; }

        private IEnumerable<GanadoDto> ListaGanado = [];

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ListaGanado = await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }
        public async Task<IEnumerable<GanadoDto>> ObtenerListado()
        {
            var resultadog = await HttpConsumir.GetAsync<IEnumerable<GanadoDto>>("/api/Ganado/ListarGanado");
            var ganado = resultadog.Response!.AsQueryable();
            ganado = ganado.Where(itemganado => itemganado.EstadoGanado);
            if (Sexo != Modelos.Enumeraciones.Sexo.Ninguno)
            {
                ganado = ganado.Where(itemganado => itemganado.SexoGanado == Sexo.ToString());
            }
            return [.. ganado];
        }

        private int? SeleccionarGanado
        {
            get => IdGanado;
            set
            {
                IdGanadoChanged.InvokeAsync(value);
            }
        }
        protected override void OnParametersSet()
        {
            if (SeleccionarGanado != IdGanado)
            {
                SeleccionarGanado = IdGanado;
            }
        }
    }
}
