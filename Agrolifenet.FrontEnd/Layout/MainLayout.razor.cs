


using Agrolifenet.FrontEnd.Autenticacion;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace Agrolifenet.FrontEnd.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        [Inject]
        private PersonalizarAuthenticationService _proveedorAutenticacion { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

                //await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/_framework/blazor.web.js");
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/bootstrap/js/bootstrap.min.js");
                //await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/js/chart.min.js");
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/js/bs-init.js");
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/js/theme.js");
            }
        }


        private void OnCerrarSesion()
        {
            var anonymous = new ClaimsPrincipal();

            _proveedorAutenticacion!.CurrentUser = anonymous;
            Navigation!.NavigateTo("/", true);
        }
    }
}
