using Agrolifenet.Dominio.Dto;

namespace Agrolifenet.Dominio.Puerto
{
    public interface IDetalleTemaRepositorio
    {
        Task AgregarDetalleTema(DateTime FechadecreacionDetalledetema, DateTime FechademodificacionDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema);
        Task<IEnumerable<DetalleTemaDto>> ListarDetalleTema(int IdTemadeconsulta);
        Task<DetalleTemaDto> BuscarDetalledetema(int IdDetalledetema);
        Task EliminarDetalleTema(int IdDetalledetema);
        Task ActualizarDetalleTema(int IdDetalledetema, DateTime FechademodificacionDetalledetema, bool EstadoDetalledetema, int IdTemadeconsulta, string EspecificacionDetalledetema);
    }
}
