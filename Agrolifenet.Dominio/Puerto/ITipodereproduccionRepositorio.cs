using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Puerto
{
    public interface ITipodereproduccionRepositorio
    {
        Task AgregarAsync(string Tiposdereproduccion, bool EstadoTipodereproduccion, DateTime FechadecreacionTipodereproduccion, DateTime FechademodificacionTipodereproduccion);
        Task<IEnumerable<TipodeReproduccion>> ListarTipodereproduccion();
        Task<TipodeReproduccion> SeleccionarTipodereproduccion(int IdTipodereproduccion);
        Task EliminarTipodereproduccion(int IdTipodereproduccion);
        Task ActualizarTipodereproduccion(int IdTipodereproduccion, string Tiposdereproduccion, bool EstadoTipodereproduccion, DateTime FechademodificacionTipodereproduccion);
    }
}
