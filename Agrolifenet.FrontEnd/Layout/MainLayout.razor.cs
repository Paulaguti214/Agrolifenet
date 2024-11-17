using Agrolifenet.FrontEnd.Puerto;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Agrolifenet.FrontEnd.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        [Inject]
        private ILoginServicio loginServicio { get; set; } = default!;

        [Inject]
        private NavigationManager Navigation { get; set; } = default!;


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/bootstrap/js/bootstrap.min.js");
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/js/bs-init.js");
                await JSRuntime.InvokeAsync<IJSObjectReference>("import", "/assets/js/theme.js");
            }
        }

        private async Task Salir()
        {
            await loginServicio.LogoutAsync();
            Navigation.NavigateTo("/Login", true);
        }
    }
}
