using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Modelos
{
    public class MenuTab
    {
        public int IdTab { get; set; }
        public string Nombre { get; set; } = default!;
        public Type Componente { get; set; } = default!;
        public bool Activo { get; set; } = false;
    }
}
