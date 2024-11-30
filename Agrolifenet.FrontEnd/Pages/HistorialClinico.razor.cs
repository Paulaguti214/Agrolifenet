using Agrolifenet.FrontEnd.Componentes.Formularios;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class HistorialClinico : ComponentBase
    {
        private readonly IEnumerable<MenuTab> menuTabs =
            [
                new(){ IdTab = 1, Nombre ="Historial Clinico", Activo = true, Componente = typeof(HistorialClinicoComponente)}
            ];
    }
}
