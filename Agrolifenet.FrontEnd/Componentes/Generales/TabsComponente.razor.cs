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
                builder.OpenComponent(0, compoenente); // Abre el componente dinámicamente
                builder.CloseComponent(); // Cierra el componente
            };
        }
    }
}
