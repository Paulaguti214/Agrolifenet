using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Agrolifenet.Infraestructura.Servicios
{
    internal class UsuarioServicio : IUsurioServicio
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IConfiguration _configuracion;

        public UsuarioServicio(IUsuarioRepositorio usuarioRepositorio, IConfiguration configuracion)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _configuracion = configuracion;
        }
        public async Task Agregar(string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario, bool BloqueoUsuario)
        {
            var fechaActual = DateTime.Now;

            await _usuarioRepositorio.AgregarAsync(IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, EstadoUsuario, fechaActual, fechaActual, BloqueoUsuario);

        }
        public Task<IEnumerable<Usuario>> ListarUsuario()
        {
            return _usuarioRepositorio.ListarUsuario();

        }

        public Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo)
        {
            return _usuarioRepositorio.SeleccionarUsuario(identificacionUsuario, tipodecargo);
        }

        public async Task EliminarUsuario(int idUsuario)
        {
            await _usuarioRepositorio.EliminarUsuario(idUsuario);
        }


        public async Task ActualizarUsuario(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario, DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, bool EstadoUsuario, bool BloqueoUsuario)
        {
            var fechaActual = DateTime.Now;
            await _usuarioRepositorio.ActualizarUsuario(idUsuario, IdentificacionUsuario, NombreUsuario, ApellidoUsuario, FechadenacimientoUsuario, CorreoelectronicoUsuario, NumerotelefonicoUsuario, fechaActual, EstadoUsuario, BloqueoUsuario);
        }

        public async Task<UsuarioTokenDto> LogeoAsync(string Usuario, string Contrasenia)
        {
            //var usuario = await _usuarioRepositorio.Logeo(Usuario, Contrasenia);
            //await Task.Delay(300);
            return GenerarToken("PEPITO");
        }

        private UsuarioTokenDto GenerarToken(string usuario)
        {
            var claims = new List<Claim> {
                new( ClaimTypes.Name ,usuario),
                new( ClaimTypes.Role ,"admin"),
                new( ClaimTypes.Role ,"xxxx")
            };

            var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuracion.GetSection("Jwt:llave").Value!));
            var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
            var expiracion = DateTime.Now.AddHours(1);
            var token = new JwtSecurityToken(issuer: default!, audience: default!, claims: claims, expires: expiracion, signingCredentials: creds);

            return new UsuarioTokenDto(new JwtSecurityTokenHandler().WriteToken(token), expiracion);
        }

    }
}
