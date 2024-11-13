using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipodecargoServicio
    {
        Task Agregar(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
    }
}
