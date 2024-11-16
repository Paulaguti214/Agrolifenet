using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipodereproduccionServicio
    {
        Task Agregar(string Tiposdereproduccion, bool EstadoTipodereproduccion);
        Task<IEnumerable<TipodeReproduccion>> Listartipodereproduccion();
        Task<TipodeReproduccion> SeleccionarTipodereproduccion(int IdTipodereproduccion);
        Task EliminarTipodereproduccion(int IdTipodereproduccion);
        Task ActualizarTipodereproduccion(int IdTipodereproduccion , string Tiposdereproduccion, bool EstadoTipodereproduccion);
    }
}
