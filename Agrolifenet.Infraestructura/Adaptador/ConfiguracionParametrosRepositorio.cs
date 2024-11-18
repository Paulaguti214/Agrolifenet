using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System.Data;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class ConfiguracionParametrosRepositorio : Repositorio<ConfiguracionParametros>, IConfiguracionParametrosRepositorio
    {
        private readonly string NombreProcedimientoGuardarConfiguracionParametros = "InsertarConfiguraciondeparametro";
        private readonly string NombreProcedimientoEliminarConfiguracionParametros = "EliminarConfiguraciondeparametro";
        private readonly string NombreProcedimientoActualizarConfiguracionParametros = "ActualizarConfiguraciondeparametros";

        public ConfiguracionParametrosRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos)
        {
        }

        public async Task ActualizarConfiguracionParametros(int IdConfiguraciondeparametros, DateTime FechadecreacionConfiguraciondeparametros, DateTime FechademodificacionConfiguraciondeparametros, bool EstadoConfiguraciondeparametros, string Tipodelparametro, string Descripciondelparamtero, int Valordelparametro, int IdTipodeParametro)
        {
            await ActualizarAsync(NombreProcedimientoActualizarConfiguracionParametros, new
            {
                IdConfiguraciondeparametros,
                FechadecreacionConfiguraciondeparametros,
                FechademodificacionConfiguraciondeparametros,
                EstadoConfiguraciondeparametros,
                Tipodelparametro,
                Descripciondelparamtero,
                Valordelparametro,
                IdTipodeParametro
            });
        }

        public async Task AgregarConfiguracionParametros(DateTime FechadecreacionConfiguraciondeparametros, DateTime FechademodificacionConfiguraciondeparametros, bool EstadoConfiguraciondeparametros, string Tipodelparametro, string Descripciondelparamtero, int Valordelparametro, int IdTipodeParametro)
        {
            await AgregarAsync(NombreProcedimientoGuardarConfiguracionParametros, new
            {
                FechadecreacionConfiguraciondeparametros,
                FechademodificacionConfiguraciondeparametros,
                EstadoConfiguraciondeparametros,
                Tipodelparametro,
                Descripciondelparamtero,
                Valordelparametro,
                IdTipodeParametro
            });
        }

        public async Task EliminarConfiguracionParametros(int IdConfiguraciondeparametros)
        {
            await EliminarAsync(NombreProcedimientoEliminarConfiguracionParametros, new { IdConfiguraciondeparametros });
        }
    }
}
