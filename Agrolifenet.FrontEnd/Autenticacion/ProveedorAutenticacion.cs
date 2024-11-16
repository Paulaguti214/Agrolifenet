using Microsoft.AspNetCore.Components.Authorization;

namespace Agrolifenet.FrontEnd.Autenticacion
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

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var anonimo = new ClaimsIdentity();
            //var usuario2 = new ClaimsIdentity(authenticationType: "prueba");
            //var usuario = new ClaimsIdentity(new List<Claim>
            //{
            //    new("identifiacion","1030650637"),
            //    new(ClaimTypes.Name,"Juan Rodriguiez"),
            //    new(ClaimTypes.Role,"admin")

            //}, authenticationType: "prueba");
            //return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(usuario)));
            return await Task.FromResult(estadoAutenticacion);
        }
    }
}
