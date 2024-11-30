using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Componentes.Generales
{
    public partial class CardComponente : ComponentBase
    {
        [Parameter] public IEnumerable<MenuTab> menuTabs { get; set; } = [];        
    }
}
