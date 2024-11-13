using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        private readonly string NombreProcedimientoGuardarUsuario = "insertarUsuario";
        private readonly string NombreProcedimientoListarUsuario = "ListarUsuario";
        private readonly string NombreProcedimientoSeleccionarUsuario = "BuscarUsuario";
        private readonly string NombreProcedimientoEliminarUsuario = "EliminarUsuario";
        private readonly string NombreProcedimientoActualizarUsuario = "ActualizarUsuario";
        private readonly string NombreProcedimientoLogeo = "Logeo";

        public UsuarioRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }



        public async Task AgregarAsync( string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario, DateTime FechadecreacionUsuario, DateTime Fechademodificacion, bool BloqueoUsuario)
        {
            await AgregarAsync(NombreProcedimientoGuardarUsuario, new
            {
                IdentificacionUsuario,
                NombreUsuario,
                ApellidoUsuario,
                FechadenacimientoUsuario,
                CorreoelectronicoUsuario,
                NumerotelefonicoUsuario,
                EstadoUsuario,
                FechadecreacionUsuario,
                Fechademodificacion,
                BloqueoUsuario

            });
        }
        public async Task<IEnumerable<Usuario>> ListarUsuario()
        {
            return await ListAsync(NombreProcedimientoListarUsuario);
        }
        public async Task<Usuario> SeleccionarUsuario(string identificacionUsuario, string? tipodecargo)
        {
            return await SeleccionarAsync(NombreProcedimientoSeleccionarUsuario, new
            {
                identificacionUsuario,
                tipodecargo
            });
        }

        public async Task EliminarUsuario(int idUsuario)
        {
            await EliminarAsync(NombreProcedimientoEliminarUsuario, new
            {
                idUsuario
            });
        }
        public async Task ActualizarUsuario(int idUsuario, string IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario, DateTime Fechademodificacion,
             bool EstadoUsuario,  bool BloqueoUsuario)
        {
            await ActualiozarAsync(NombreProcedimientoActualizarUsuario, new
            {
                idUsuario,
                IdentificacionUsuario,
                NombreUsuario,
                ApellidoUsuario,
                FechadenacimientoUsuario,
                CorreoelectronicoUsuario,
                NumerotelefonicoUsuario,
                @Fechademodificacion,
                EstadoUsuario,
                BloqueoUsuario

            });
        }

        public async Task<Usuario> Logeo(string Usuario, string Contrasenia)
        {
            return await SeleccionarAsync(NombreProcedimientoLogeo, new
            {
                Usuario,
                Contrasenia
            });
        }
    }
}
