using Agrolifenet.FrontEnd.Componentes.Formularios;
using Agrolifenet.FrontEnd.Modelos;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class Ventas : ComponentBase
    {
        private readonly IEnumerable<MenuTab> menuTabs =
            [
                new(){ IdTab = 2, Nombre ="Generar Venta", Activo = true, Componente = typeof(VentasComponente)},
                new(){ IdTab = 1, Nombre ="Ver Factruas", Componente = typeof(FacturasComponente)}
           ];
    }
}
