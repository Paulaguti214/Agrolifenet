using Agrolifenet.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrolifenet.Dominio.Servicios
{
    public interface ITipodeparametroServicio
    {

        Task Agregar(string Tiposdeparametros,  bool EstadoTipodeparametro);
        Task<IEnumerable<TipodeParametro>> ListarTipodeparametro();
        Task<TipodeParametro> SeleccionarTipodeparametro(int IdTipodeparametro);
        Task EliminarTipodeparametro(int IdTipodeparametro);
        Task ActualizarTipodeparametro(int IdTipodeparametro, string Tiposdeparametros,  bool EstadoTipodeparametro);
    }
}

    

