using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales.Raza
{
    public partial class CbxRaza : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;
        [Parameter] public int? IdTipoAnimal { get; set; }
        [Parameter] public int IdRaza { get; set; }
        [Parameter] public EventCallback<int> IdRazaChanged { get; set; }

        private IEnumerable<ListarRazaDto> ListaRazas = [];

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await ObtenerListado();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            if (SeleccionarRaza != IdRaza)
            {
                SeleccionarRaza = IdRaza;
            }

            await ObtenerListado();
            Console.WriteLine(IdTipoAnimal);
        }

        public async Task ObtenerListado()
        {
            ListaRazas = new List<ListarRazaDto>();

            try
            {
                var resultado = await HttpConsumir.GetAsync<IEnumerable<ListarRazaDto>>("/api/Raza/LisatarRaza");

                if (!resultado.Error)
                {
                    Console.WriteLine("Solicitud HTTP exitosa.");
                    ListaRazas = resultado.Response!.ToList();
                    Console.WriteLine($"cantidad 1: {ListaRazas.Count()}");
                    Console.WriteLine($"id tipo animal seleccionado: {IdTipoAnimal}");
                    foreach (var item in ListaRazas)
                    {
                        Console.WriteLine($"Tipo de raza: {item.IdTipoanimal}");
                    }
                    Console.WriteLine("Filtrando por IdTipoAnimal...");

                    if (IdTipoAnimal is not null && IdTipoAnimal != 0)
                    {
                        ListaRazas = ListaRazas.Where(tipoAnimal => tipoAnimal.IdTipoanimal == IdTipoAnimal).ToList();
                    }
                    Console.WriteLine($"cantidad 2: {ListaRazas.Count()}");
                    foreach (var item in ListaRazas)
                    {
                        Console.WriteLine($"Tipo de raza: {item.Tipoderaza}");
                    }
                }
                else
                {
                    Console.WriteLine("Error en la solicitud HTTP.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción al realizar la solicitud HTTP: {ex.Message}");
            }

            Console.WriteLine("Finalizó ObtenerListado.");
        }

        private int SeleccionarRaza
        {
            get => IdRaza;
            set
            {
                IdRazaChanged.InvokeAsync(value);
            }
        }
    }
}
