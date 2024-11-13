using Agrolifenet.Dominio.Entidades;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipodecargoServicio
    {
        Task Agregar(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
        Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo();
        Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo);
        Task EliminarTiposdecargo(int idTiposdecargo);
        Task ActualizarTiposdecargo(int idTiposdecargo, string tipodecargo, DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
    }
}
