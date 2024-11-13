using Microsoft.AspNetCore.Components.Authorization;

namespace Agrolifenet.Front.Autenticacion
{
    public class ProveedorAutenticacion : AuthenticationStateProvider
    {
        private AuthenticationState estadoAutenticacion;

        public ProveedorAutenticacion(PersonalizarAuthenticationService personalizarAuthenticationService)
        {
            estadoAutenticacion = new AuthenticationState(personalizarAuthenticationService.CurrentUser);

            personalizarAuthenticationService.UserChanged += (usuarioNuevo) =>
            {
                estadoAutenticacion = new AuthenticationState(usuarioNuevo);
                NotifyAuthenticationStateChanged(Task.FromResult(estadoAutenticacion));
            };
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(estadoAutenticacion);
    }
}
