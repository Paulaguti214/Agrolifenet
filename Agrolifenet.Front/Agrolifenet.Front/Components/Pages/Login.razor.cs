using Agrolifenet.Front.Autenticacion;
using Microsoft.AspNetCore.Components;

namespace Agrolifenet.Front.Components.Pages
{
    public partial class Login : ComponentBase
    {
        [Inject]
        private ProveedorAutenticacion usurioServicio { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        private Modelos.Login loginModelo = new();
        private string errorMessage;

        private async void OnValidSubmit()
        {
            await usurioServicio.LoginAsync(loginModelo.Usuario, loginModelo.Contrasenia);
            Navigation.NavigateTo("/");
            //if (usuario is not null)
            //{

            //}
            //else
            //{
            //    errorMessage = "Inicio de sesión fallido. Por favor, verifica tus credenciales.";
            //}
        }
    }
}
