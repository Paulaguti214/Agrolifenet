using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Infraestructura.Adaptador
{
   public class UsuarioRepositorio : Repositorio<Usuario> , IUsuarioRepositorio
    {
        private readonly string NombreProcedimientoGuardar = "insertarUsuario";
        public UsuarioRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }

        public Task ActualizarUsuario(int idTipoanimal, string tiposdeanimal, DateTime fechademodificacionTipoanimal, bool estadoTipoanimal)
        {
            throw new NotImplementedException();
        }

        public async Task AgregarAsync(int IdentificacionUsuario, string NombreUsuario, string ApellidoUsuario,
             DateTime FechadenacimientoUsuario, string CorreoelectronicoUsuario, string NumerotelefonicoUsuario,
             bool EstadoUsuario, DateTime FechadecreacionUsuario, DateTime Fechademodificacion, bool BloqueoUsuario)
        {
            await AgregarAsync(NombreProcedimientoGuardar, new
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

        public Task EliminarUsuario(int idTipoanimal)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ListarUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> SeleccionarUsuario(int idTipoanimal)
        {
            throw new NotImplementedException();
        }
    }
}
