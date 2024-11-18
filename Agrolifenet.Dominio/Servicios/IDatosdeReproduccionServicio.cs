using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Infraestructura.Servicios
{
    public interface IDatosdeReproduccionServicio
    {
        Task AgregarDatosdeReproduccion(
            int IdRepruductor,
            bool Resultadodelareproduccion,
            string ObservacionesDatosdereproduccion,
            bool EstadoDatosdereproduccion,
            DateTime Fechadelprocesodereproduccion,
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
            int IdTipodereproduccion
        );
    }
}
