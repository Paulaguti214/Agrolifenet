using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class ConfiguracionParametrosServicio : IConfiguracionParametrosServicio
    {
        private readonly IConfiguracionParametrosRepositorio _configuracionParametrosRepositorio;

        public ConfiguracionParametrosServicio(IConfiguracionParametrosRepositorio configuracionParametrosRepositorio)
        {
            _configuracionParametrosRepositorio = configuracionParametrosRepositorio;
        }
        public async Task ActualizarConfiguracionParametros(int IdConfiguraciondeparametros, bool EstadoConfiguraciondeparametros, string Tipodelparametro, string Descripciondelparamtero, int Valordelparametro, int IdTipodeParametro)
        {
            var fechaActual = DateTime.Now;
            await _configuracionParametrosRepositorio.ActualizarConfiguracionParametros(IdConfiguraciondeparametros, fechaActual, fechaActual, EstadoConfiguraciondeparametros, Tipodelparametro, Descripciondelparamtero, Valordelparametro, IdTipodeParametro);
        }

        public async Task AgregarConfiguracionParametros(bool EstadoConfiguraciondeparametros, string Tipodelparametro, string Descripciondelparamtero, int Valordelparametro, int IdTipodeParametro)
        {
            var fechaActual = DateTime.Now;
            await _configuracionParametrosRepositorio.AgregarConfiguracionParametros(fechaActual, fechaActual, EstadoConfiguraciondeparametros, Tipodelparametro, Descripciondelparamtero, Valordelparametro, IdTipodeParametro);
        }

        public async Task EliminarConfiguracionParametros(int IdConfiguraciondeparametros)
        {
            await _configuracionParametrosRepositorio.EliminarConfiguracionParametros(IdConfiguraciondeparametros);
        }
    }
}
