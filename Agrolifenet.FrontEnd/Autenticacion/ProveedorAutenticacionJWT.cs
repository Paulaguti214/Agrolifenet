using Agrolifenet.FrontEnd.Helpers;
using Agrolifenet.FrontEnd.Puerto;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Agrolifenet.FrontEnd.Autenticacion
{
    public class ProveedorAutenticacionJWT : AuthenticationStateProvider, ILoginServicio
    {
        private readonly IJSRuntime _jSRuntime;
        private readonly HttpClient _httpClient;
        private static readonly string Key = "TOKEN";
        private AuthenticationState Anonimo => new(new ClaimsPrincipal(new ClaimsIdentity()));

        public ProveedorAutenticacionJWT(IJSRuntime jSRuntime, HttpClient httpClient)
        {
            _jSRuntime = jSRuntime;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _jSRuntime.ObtenerEnLocalStorage(Key);
            if (string.IsNullOrEmpty(token?.ToString()))
            {
                return await Task.FromResult(Anonimo);
            }
            return await Task.FromResult(ConstruirAuthenticationState(token.ToString()!));
        }


        private AuthenticationState ConstruirAuthenticationState(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new("bearer", token);
            var claims = ObtenerClaimsToken(token);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(claims, "Jwt")));
        }

        private static IEnumerable<Claim> ObtenerClaimsToken(string token)
        {
            var jwtSecurityToken = new JwtSecurityTokenHandler();
            var lecturaToken = jwtSecurityToken.ReadJwtToken(token);

            return lecturaToken.Claims;
        }

        public async Task LoginAsync(string Token)
        {
            await _jSRuntime.GuardarEnLocalStorage(Key, Token);
            var autenticacion = ConstruirAuthenticationState(Token);
            NotifyAuthenticationStateChanged(Task.FromResult(autenticacion));
        }

        public async Task LogoutAsync()
        {
            await _jSRuntime.RemoverEnLocalStorage(Key);
            _httpClient.DefaultRequestHeaders.Authorization = default!;
            NotifyAuthenticationStateChanged(Task.FromResult(Anonimo));
        }
    }
}

