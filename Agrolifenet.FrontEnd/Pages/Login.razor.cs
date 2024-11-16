
using Agrolifenet.FrontEnd.Autenticacion;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class Login : ComponentBase
    {

        [Inject]
        IJSRuntime Js { get; set; }

        [Inject]
        private PersonalizarAuthenticationService? CustomAuthenticationService { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationState { get; set; }

        private FrontEnd.Modelos.Login loginModelo = new();
        private string? errorMessage;


        private async void OnValidSubmit()
        {
            var ss = await AuthenticationState;
            var ssss = ss.User.Identity?.IsAuthenticated;
            var usuario = "ss";
            if (usuario != null)
            {
                var identity = new ClaimsIdentity(
                    [
                        new Claim(ClaimTypes.Name, usuario),
                    ],
                    "Custom Authentication");

                var usuarioNuevo = new ClaimsPrincipal(identity);

                CustomAuthenticationService!.CurrentUser = usuarioNuevo;
                //await Js.GuardarEnLocalStorage("usuario", "pepito");
                Navigation!.NavigateTo("/", true);
            }
            else
            {
                errorMessage = "Ingresa usuario y contraseña correctos";
            }
        }
    }
}
