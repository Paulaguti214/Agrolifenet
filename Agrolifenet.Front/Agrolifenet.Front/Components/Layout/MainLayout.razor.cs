using Agrolifenet.Front.Autenticacion;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;

namespace Agrolifenet.Front.Components.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        private PersonalizarAuthenticationService _proveedorAutenticacion { get; set; }

        [Inject]
        private NavigationManager? Navigation { get; set; }

        private void OnCerrarSesion()
        {
            var anonymous = new ClaimsPrincipal(new ClaimsIdentity());

            _proveedorAutenticacion!.CurrentUser = anonymous;
            Navigation!.NavigateTo("/", true);
        }
    }
}
