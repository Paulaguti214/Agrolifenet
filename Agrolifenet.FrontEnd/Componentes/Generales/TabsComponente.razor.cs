using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales
{
    public partial class TabsComponente : ComponentBase
    {
        [CascadingParameter] public IEnumerable<MenuTab> MenuTabs { get; set; } = [];
        private static RenderFragment ConstruirComponente(Type compoenente)
        {
            return builder =>
            {
                Random random = new Random();
                int numeroalaetorio = random.Next();
                builder.OpenComponent(numeroalaetorio, compoenente);
                builder.CloseComponent();
            };
        }
    }
}
