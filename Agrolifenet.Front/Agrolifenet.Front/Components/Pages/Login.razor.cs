using Agrolifenet.Dominio.Servicios;
using Agrolifenet.Front.Autenticacion;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace Agrolifenet.Front.Components.Pages
{
    public partial class Login : ComponentBase
    {
        [Inject]
        private IUsurioServicio _usurioServicio { get; set; }

        [Inject]
        private PersonalizarAuthenticationService? CustomAuthenticationService { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        private Modelos.Login loginModelo = new();
        private string? errorMessage;

        private async void OnValidSubmit()
        {
            var usuario = await _usurioServicio.LogeoAsync(loginModelo.Usuario, loginModelo.Contrasenia);
            if (usuario != null)
            {
                var identity = new ClaimsIdentity(
                    [
                        new Claim(ClaimTypes.Name, usuario.Token.ToString()),
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
