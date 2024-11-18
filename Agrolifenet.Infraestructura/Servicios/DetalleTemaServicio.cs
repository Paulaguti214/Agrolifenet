using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Dominio.Servicios;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class DetalleTemaServicio : IDetalleTemaServicio
    {
        private readonly IDetalleTemaRepositorio _detalleTemaRepositorio;

        public DetalleTemaServicio(IDetalleTemaRepositorio detalleTemaRepositorio)
        {
            _detalleTemaRepositorio = detalleTemaRepositorio;
        }

        public async Task ActualizarDetalleTema(int IdDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            var fechaActual = DateTime.Now;
            await _detalleTemaRepositorio.ActualizarDetalleTema(IdDetalledetema, fechaActual, EstadoDetalledetema, IdTemadeconsulta, EspecificacionDetalledetema);
        }

        public async Task AgregarDetalleTema(bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema)
        {
            var fechaActual = DateTime.Now;
            await _detalleTemaRepositorio.AgregarDetalleTema(fechaActual, fechaActual, EstadoDetalledetema, IdTemadeconsulta, EspecificacionDetalledetema);
        }

        public async Task<DetalleTemaDto> BuscarDetalledetema(int IdDetalledetema)
        {
            return await _detalleTemaRepositorio.BuscarDetalledetema(IdDetalledetema);
        }

        public async Task EliminarDetalleTema(int IdDetalledetema)
        {
            await _detalleTemaRepositorio.EliminarDetalleTema(IdDetalledetema);
        }

        public async Task<IEnumerable<DetalleTemaDto>> ListarDetalleTema(int IdTemadeconsulta)
        {
            return await _detalleTemaRepositorio.ListarDetalleTema(IdTemadeconsulta);
        }
    }
}
