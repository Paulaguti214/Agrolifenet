using Agrolifenet.FrontEnd.Componentes.Formularios;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class RegistroAnimal : ComponentBase
    {
        private readonly IEnumerable<MenuTab> menuTabs =
            [  
                new(){ IdTab = 2, Nombre ="Tipo Animal", Activo = true, Componente = typeof(TipoAnimalComponente)},
                new(){ IdTab = 1, Nombre ="Raza", Componente = typeof(RazaComponent)},              
                new(){ IdTab = 3, Nombre ="Ganado", Componente = typeof(GanadoComponent)}
            ];
    }
}
