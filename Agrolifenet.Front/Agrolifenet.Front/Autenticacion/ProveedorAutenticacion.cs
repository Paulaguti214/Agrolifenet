using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Agrolifenet.Front.Autenticacion
{
    public class ProveedorAutenticacion(IUsurioServicio usurioServicio) : AuthenticationStateProvider
    {
        private Usuario _usuarioInformacion = default!;

        public async Task LoginAsync(string usuario, string constrasenia)
        {
            _usuarioInformacion = await usurioServicio.Logeo(usuario, constrasenia);

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, _usuarioInformacion.IdentificacionUsuario.ToString())
            },
            "apiauth_type");

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (_usuarioInformacion != null)
            {
                var identity = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name,_usuarioInformacion.IdentificacionUsuario.ToString()),
            }, "apiauth_type");

                var user = new ClaimsPrincipal(identity);
                return Task.FromResult(new AuthenticationState(user));
            }
            else
            {
                var anonymous = new ClaimsPrincipal(new ClaimsIdentity());
                return Task.FromResult(new AuthenticationState(anonymous));
            }
        }

        public async Task LogoutAsync()
        {
            _usuarioInformacion = default!;
            var anonymous = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymous)));
        }
    }
}
