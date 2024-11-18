using Agrolifenet.Dominio.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Agrolifenet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfiguracionParametrosController : ControllerBase
    {
        private readonly IConfiguracionParametrosServicio _configuracionParametrosServicio;

        public ConfiguracionParametrosController(IConfiguracionParametrosServicio configuracionParametrosServicio)
        {
            _configuracionParametrosServicio = configuracionParametrosServicio;
        }

        [HttpPost("AgregarDatosReproduccion")]
        public async Task AgregarDatosReproduccion(
            bool EstadoConfiguraciondeparametros,
            string Tipodelparametro,
            string Descripciondelparamtero,
            int Valordelparametro,
            int IdTipodeParametro)
        {
            await _configuracionParametrosServicio.AgregarConfiguracionParametros(EstadoConfiguraciondeparametros, Tipodelparametro, Descripciondelparamtero, Valordelparametro, IdTipodeParametro);
        }

        [HttpDelete("EliminarDatosReproduccion")]
        public async Task EliminarDatosReproduccion(int IdConfiguraciondeparametros)
        {
            await _configuracionParametrosServicio.EliminarConfiguracionParametros(IdConfiguraciondeparametros);
        }

        [HttpPut("ActualizarDatosReproduccion")]
        public async Task ActualizarDatosReproduccion(
            int IdConfiguraciondeparametros,
            bool EstadoConfiguraciondeparametros,
            string Tipodelparametro,
            string Descripciondelparamtero,
            int Valordelparametro,
            int IdTipodeParametro)
        {
            await _configuracionParametrosServicio.ActualizarConfiguracionParametros(
                IdConfiguraciondeparametros,
                EstadoConfiguraciondeparametros,
                Tipodelparametro,
                Descripciondelparamtero,
                Valordelparametro,
                IdTipodeParametro);
        }
    }
}
