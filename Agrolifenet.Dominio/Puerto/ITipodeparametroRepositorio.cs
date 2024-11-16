using Agrolifenet.Dominio.Entidades;
using Agrolifenet.Dominio.Puerto.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Puerto
{
    public  interface ITipodeparametroRepositorio : IRepositorio<TipodeParametro>
    {
        Task AgregarAsync(string Tiposdeparametros, DateTime FechadecreacionTipodeparametro,DateTime FechademodificacionTipodeparametro,bool EstadoTipodeparametro);
        Task<IEnumerable<TipodeParametro>> ListarTipodeparametro();
        Task<TipodeParametro> SeleccionarTipodeparametro(int IdTipodeparametro);
        Task EliminarTipodeparametro(int IdTipodeparametro);
        Task ActualizarTipodeparametro(int IdTipodeparametro, string Tiposdeparametros,  DateTime FechademodificacionTipodeparametro, bool EstadoTipodeparametro);
    }
}
