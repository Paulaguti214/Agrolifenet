using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.Front.Components.Pages
{
    public partial class Login : ComponentBase
    {
        [Inject]
        private IUsurioServicio usurioServicio { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        private Modelos.Login loginModelo = new();
        private string errorMessage;

        private async void OnValidSubmit()
        {
            var usuario = await usurioServicio.Logeo(loginModelo.Usuario, loginModelo.Contrasenia);
            if (usuario is not null)
            {
                Navigation.NavigateTo("/");
            }
            else
            {
                errorMessage = "Inicio de sesión fallido. Por favor, verifica tus credenciales.";
            }
        }
    }
}
