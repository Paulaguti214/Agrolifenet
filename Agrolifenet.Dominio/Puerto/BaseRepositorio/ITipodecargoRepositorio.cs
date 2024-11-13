using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Puerto.BaseRepositorio
{
    public interface ITipodecargoRepositorio : IRepositorio<TiposdeCargo>
    {
        Task AgregarAsync(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo,
            bool estadoTiposdecargo);
    }
}
