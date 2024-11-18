using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IDatosdeReproduccionRepositorio
    {
        Task AgregarDatosdeReproduccion(
            int IdRepruductor,
            bool Resultadodelareproduccion,
            string ObservacionesDatosdereproduccion,
            bool EstadoDatosdereproduccion,
            DateTime Fechadelprocesodereproduccion,
            DateTime FechadecreacionDatosdereproduccion,
            DateTime FechademodificacionDatosdereproduccion,
            int IdTipodereproduccion
        );
        Task<IEnumerable<DatosReproduccionDto>> ListarDatosdeReproduccion(int IdGanado);
        Task<DatosReproduccionDto> BuscarDatosdeReproduccion(int IdDatosdereproduccion);
        Task EliminarDatosdeReproduccion(int IdDatosdereproduccion);
        Task ActualizarDatosdeReproduccion(
            int IdDatosdereproduccion,
            int IdRepruductorDatosdereproduccion,
            bool Resultadodelareproduccion,
            string ObservacionesDatosdereproduccion,
            bool EstadoDatosdereproduccion,
            DateTime Fechadelprocesodereproduccion,
            DateTime FechadecreacionDatosdereproduccion,
            DateTime FechademodificacionDatosdereproduccion,
            int IdTipodereproduccion
        );
    }
}
