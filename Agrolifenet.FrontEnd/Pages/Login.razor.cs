
using Agrolifenet.FrontEnd.Autenticacion;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class Login : ComponentBase
    {


        [Inject]
        private PersonalizarAuthenticationService? CustomAuthenticationService { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        private FrontEnd.Modelos.Login loginModelo = new();
        private string? errorMessage;

        private async void OnValidSubmit()
        {
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
                Navigation!.NavigateTo("/", true);
            }
            else
            {
                errorMessage = "Ingresa usuario y contraseña correctos";
            }
        }
    }
}
