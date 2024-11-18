using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;
using Agrolifenet.Infraestructura.Adaptador;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace Agrolifenet.Infraestructura.Extenciones
{
    public static class PersistenciaExtensions
    {
        public static IServiceCollection AgregarServiciosPersistencia(this IServiceCollection svc, IConfiguration configuracion)
        {
            string cadenaConexion = configuracion.GetSection("SqlServer:cadenaConexion").Value!;

            svc.AddTransient<IDbConnection>(db => new SqlConnection(cadenaConexion));

            svc.AddTransient(typeof(IRepositorio<>), typeof(Repositorio<>));

            svc.AddTransient<ITipoAnimalRepositorio, TipoAnimalRepositorio>();

            svc.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            svc.AddTransient<ITipodecargoRepositorio, TipodecargoRepositorio>();
            svc.AddTransient<ITipodereproduccionRepositorio, TipodereproduccionRepositorio>();
            svc.AddTransient<ITipodeparametroRepositorio, TipodeparametroRepositorio>();
            svc.AddTransient<ITemadeconsultaRepositorio, TemadeconsultaRepositorio>();
            svc.AddTransient<IGanadoRepositorio, GanadoRepositorio>();
            svc.AddTransient<IVentaRepositorio, VentaRepositorio>();
            svc.AddTransient<IRazaRepositorio, RazaRepositorio>();
            svc.AddTransient<IUsuarioTiposdeCargoRepositorio, UsuarioTiposdeCargoRepositorio>();
            svc.AddTransient<IHistorialClinicoRepositorio, HistorialClinicoRepositorio>();
            svc.AddTransient<IDetalleVentaRepositorio, DetalleVentaRepositorio>();
            svc.AddTransient<IDetalleTemaRepositorio, DetalleTemaRepositorio>();
            svc.AddTransient<IDatosdeReproduccionRepositorio, DatosdeReproduccionRepositorio>();

            return svc;
        }
    }
}
