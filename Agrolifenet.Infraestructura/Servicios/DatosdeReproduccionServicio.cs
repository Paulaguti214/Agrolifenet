using Agrolifenet.Dominio.Dto;
using Agrolifenet.Dominio.Puerto;

namespace Agrolifenet.Infraestructura.Servicios
{
    public class DatosdeReproduccionServicio : IDatosdeReproduccionServicio
    {
        private readonly IDatosdeReproduccionRepositorio _datosdeReproduccionRepositorio;

        public DatosdeReproduccionServicio(IDatosdeReproduccionRepositorio datosdeReproduccionRepositorio)
        {
            _datosdeReproduccionRepositorio = datosdeReproduccionRepositorio;
        }
        public async Task ActualizarDatosdeReproduccion(int IdDatosdereproduccion, int IdRepruductorDatosdereproduccion, bool Resultadodelareproduccion, string ObservacionesDatosdereproduccion, bool EstadoDatosdereproduccion, DateTime Fechadelprocesodereproduccion, int IdTipodereproduccion)
        {
            var fechaActual = DateTime.Now;
            await _datosdeReproduccionRepositorio.ActualizarDatosdeReproduccion(IdDatosdereproduccion, IdRepruductorDatosdereproduccion, Resultadodelareproduccion, ObservacionesDatosdereproduccion, EstadoDatosdereproduccion, Fechadelprocesodereproduccion, fechaActual, fechaActual, IdTipodereproduccion);
        }

        public async Task AgregarDatosdeReproduccion(int IdRepruductor, bool Resultadodelareproduccion, string ObservacionesDatosdereproduccion, bool EstadoDatosdereproduccion, DateTime Fechadelprocesodereproduccion, int IdTipodereproduccion)
        {
            var fechaActual = DateTime.Now;
            await _datosdeReproduccionRepositorio.AgregarDatosdeReproduccion(IdRepruductor, Resultadodelareproduccion, ObservacionesDatosdereproduccion, EstadoDatosdereproduccion, Fechadelprocesodereproduccion, fechaActual, fechaActual, IdTipodereproduccion);
        }

        public async Task<DatosReproduccionDto> BuscarDatosdeReproduccion(int IdDatosdereproduccion)
        {
            return await _datosdeReproduccionRepositorio.BuscarDatosdeReproduccion(IdDatosdereproduccion);
        }

        public async Task EliminarDatosdeReproduccion(int IdDatosdereproduccion)
        {
            await _datosdeReproduccionRepositorio.EliminarDatosdeReproduccion(IdDatosdereproduccion);
        }

        public async Task<IEnumerable<DatosReproduccionDto>> ListarDatosdeReproduccion(int IdGanado)
        {
            return await _datosdeReproduccionRepositorio.ListarDatosdeReproduccion(IdGanado);
        }
    }
}
