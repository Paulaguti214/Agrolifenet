using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipodecargoServicio
    {
        Task Agregar(string tipodecargo,  bool estadoTiposdecargo);
        Task<IEnumerable<TiposdeCargo>> ListarTiposdecargo();
        Task<TiposdeCargo> SeleccionarTiposdecargo(int idTiposdecargo);
        Task EliminarTiposdecargo(int idTiposdecargo);
        Task ActualizarTiposdecargo(int idTiposdecargo, string tipodecargo,bool estadoTiposdecargo);
    }
}
