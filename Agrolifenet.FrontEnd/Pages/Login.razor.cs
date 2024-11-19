using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Modelos;
using Agrolifenet.FrontEnd.Puerto;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;


namespace Agrolifenet.FrontEnd.Pages
{
    public partial class Login : ComponentBase
    {
        [Inject]
        IHttpConsumir HttpConsumir { get; set; } = default!;

        [Inject]
        SweetAlertService Swal { get; set; } = default!;

        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        [Inject]
        private ILoginServicio loginServicio { get; set; } = default!;

        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

        private Modelos.Login loginModelo = new();

        protected override async Task OnInitializedAsync()
        {
            // Obtiene el estado de autenticación
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            // Verifica si el usuario no está autenticado
            if (user == null || user?.Identity == null || user!.Identity!.IsAuthenticated)
            {
                // Redirige a la página de inicio de sesión
                Navigation.NavigateTo("/", true);
            }
        }

        private async Task OnValidSubmit()
        {
            var resultado = await HttpConsumir.PostAsync<Modelos.Login, UsuarioTokenDto>("/api/Cuenta/Login", loginModelo);
            if (resultado.Error)
            {
                await Swal.FireAsync("Error", await resultado.ObetenerMensajeErrorAsync(), SweetAlertIcon.Error);
            }
            else
            {
                await loginServicio.LoginAsync(resultado.Response!.Token);
                Navigation.NavigateTo("/", true);
            }
        }
    }
}
