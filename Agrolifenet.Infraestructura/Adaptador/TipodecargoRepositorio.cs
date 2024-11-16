using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto;
using Agrolifenet.Infraestructura.Adaptador.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Infraestructura.Adaptador
{
    public class TipodecargoRepositorio : Repositorio<TiposdeCargo>, ITipodecargoRepositorio
    {
        public TipodecargoRepositorio(IDbConnection baseDeDatos) : base(baseDeDatos) { }

        public Task AgregarAsync(string tipodecargo, DateTime fechadecreacionTiposdecargo, DateTime fechademodificacionTiposdecargo, bool estadoTiposdecargo)
        {
            throw new NotImplementedException();
        }
    }
}
