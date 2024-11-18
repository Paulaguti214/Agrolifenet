using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Servicios
{
    public interface IDetalleTemaServicio
    {
        Task AgregarDetalleTema(bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema);
        Task<IEnumerable<DetalleTemaDto>> ListarDetalleTema(int IdTemadeconsulta);
        Task<DetalleTemaDto> BuscarDetalledetema(int IdDetalledetema);
        Task EliminarDetalleTema(int IdDetalledetema);
        Task ActualizarDetalleTema(int IdDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema);
    }
}
