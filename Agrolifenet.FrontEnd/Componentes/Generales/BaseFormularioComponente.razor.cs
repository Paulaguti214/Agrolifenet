using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Agrolifenet.FrontEnd.Componentes.Generales
{
    public partial class BaseFormularioComponente<TModelo> : ComponentBase
    {
        [EditorRequired]
        [Parameter] public string NombreFormulario { get; set; } = default!;

        [EditorRequired]
        [Parameter] public RenderFragment ContenidoFormulario { get; set; } = default!;

        [EditorRequired]
        [Parameter] public TModelo Modelo { get; set; } = default!;
        [EditorRequired]
        [Parameter] public EventCallback<TModelo> Ejecutar { get; set; }

        [Parameter] public string NombreEncabezadoDetalle { get; set; } = default!;
        [Parameter] public RenderFragment ContenidoDetalle { get; set; } = default!;
        private bool RenderFragmentTieneContenido { get; set; }

        private async Task OnSubmit()
        {
            if (Ejecutar.HasDelegate)
            {
                await Ejecutar.InvokeAsync(Modelo);
            }
        }


        protected override void OnParametersSet()
        {
            if (ContenidoDetalle != null)
            {
                RenderFragmentTieneContenido = VerificarContenido(ContenidoDetalle);
            }
        }

        private bool VerificarContenido(RenderFragment fragment)
        {
            if (fragment == null)
                return false;

            var tieneContenido = false;

            var builder = new RenderTreeBuilder();
            fragment(builder);

            tieneContenido = builder.GetFrames().Array.Length > 0;
            return tieneContenido;
        }
    }
}
